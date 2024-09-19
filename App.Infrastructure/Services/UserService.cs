using App.Application.Exceptions;
using App.Application.Features.AuthFeatures.CommandHandlers;
using App.Application.Interfaces;
using App.Domain.Abstractions;
using App.Infrastructure.Identity;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace App.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUowRepo _uowRepo;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public UserService(IUowRepo uowRepo, IMapper mapper, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager)
        {
            _uowRepo = uowRepo;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public async Task<(bool isSucceed, string userId)> CreateUserAsync(RegisterUserCommend model)
        {

            var user = new ApplicationUser()
            {
                FirstName = model.FirstName.Trim(),
                LastName = model.LastName.Trim(),
                Email = model.Email.Trim(),
                PhoneNumber = model.Phone.Trim(),
                Longitude = model?.Longitude?.Trim(),
                Latitude = model?.Latitude?.Trim(),
                UserName = model?.UserName?.Trim(),
            };
            // Check if all roles exist
            foreach (var role in model.Roles)
            {
                if (await _roleManager.FindByNameAsync(role) == null)
                {
                    throw new NotFoundException("One or more roles are invalid.");
                }
            }
            // Create user
            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                var errorMessages = string.Join(", ", result.Errors.Select(e => e.Description));
                throw new Exception($"User creation failed: {errorMessages}");
            }
            // Add user to roles
            var addUserRole = await _userManager.AddToRolesAsync(user, model.Roles);
            if (!addUserRole.Succeeded)
            {
                var errorMessages = string.Join(", ", result.Errors.Select(e => e.Description));
                throw new Exception($"Role creation failed: {errorMessages}");
            }

            return (isSucceed: true, userId: user.Id) ;
        }
    }
}
