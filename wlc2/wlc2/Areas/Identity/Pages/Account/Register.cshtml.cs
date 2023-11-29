// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using wlc2.Data;
using wlc2.Models;

namespace wlc2.Areas.Identity.Pages.Account
{
    [Authorize(Roles = "Admin")]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IUserStore<IdentityUser> _userStore;
        private readonly IUserEmailStore<IdentityUser> _emailStore;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        /// <summary>
        /// This object contains Database data.
        /// </summary>
        private readonly ApplicationDbContext _context;

        // This object contains Students data.
        public List<Student> Students { get; set; }

        // This object contains Students data.
        public List<Advisor> Advisors { get; set; }

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            IUserStore<IdentityUser> userStore,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _context = context;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            /// <summary>
            /// Collects student data.
            /// </summary>
            public Student Student { get; set; }

            /// <summary>
            /// Collects advisor data.
            /// </summary>
            public Advisor Advisor { get; set; }

            /// <summary>
            /// Collects active tab id.
            /// </summary>
            public string ActiveTab { get; set; }
        }


        public async Task OnGetAsync(string returnUrl = null)
        {
            // Send to view the list of identification types.
            ViewData["IdentificationTypesFK"] = new SelectList(_context.IdentificationTypes, "Id", "Name");
            // Send to view the list of nationalities.
            ViewData["NationalitiesFK"] = new SelectList(_context.Nationalities, "Id", "Name");
            // Send to view the list of students.
            Students = await _context.Students.ToListAsync();
            // Send to view the list of advisors.
            Advisors = await _context.Advisors.ToListAsync();

            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null, string ActiveTab = null)
        {

            // This variable contains the person role we want to create.
            string personRole = null;

            // Verify what type of person (his role) we want to create.
            if ( ActiveTab == "student-tab" || ActiveTab == null)
            {
                personRole = "Student";
            }
            if ( ActiveTab == "advisor-tab" )
            {
                personRole = "Advisor";
            }

            // Creates an user object.
            var user = CreateUser();

            // Sets user Username and Email.
            await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
            await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);
            
            // Adds user to Database.
            var result = await _userManager.CreateAsync(user, Input.Password);

            // Automatically confirm email.
            user.EmailConfirmed = true;

            // Add role to the new user.
            await _userManager.AddToRoleAsync(user, personRole);
            
            // TODO: Criar uma entrada para a pessoa.
            // Creates the person.
            try
            {
                if ( personRole == "Student" ) {
                    // Is student:
                    Input.Student.UserId = user.Id;
                    Input.Student.Email = Input.Email;
                    if ( Input.Student.Sex == 0 ) { 
                        Input.Student.Sex = PersonSex.male; 
                    } else {
                        Input.Student.Sex = PersonSex.female;
                    }
                    _context.Add(Input.Student);
                    await _context.SaveChangesAsync();
                    Students = await _context.Students.ToListAsync();
                    Advisors = await _context.Advisors.ToListAsync();
                } else if ( personRole == "Advisor" ) {
                    // Is advisor:
                    Input.Advisor.UserId = user.Id;
                    Input.Advisor.Email = Input.Email;
                    _context.Add(Input.Advisor); 
                    await _context.SaveChangesAsync();
                    Students = await _context.Students.ToListAsync();
                    Advisors = await _context.Advisors.ToListAsync();
                }
            } catch (Exception)
            {
                await _userManager.DeleteAsync(user);
                ModelState.AddModelError("", "Algo correu mal ao criar um utilizador.");
                return Page();
            }

            return Page();

        }

        private IdentityUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<IdentityUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(IdentityUser)}'. " +
                    $"Ensure that '{nameof(IdentityUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<IdentityUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<IdentityUser>)_userStore;
        }
    }
}
