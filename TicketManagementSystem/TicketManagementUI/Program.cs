using Domain.Entities;
using Domain.Interfaces;
using Domain.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using TicketManagementUI.Components;
using TicketManagementUI.Security;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
	.AddInteractiveServerComponents();

/* Authentication */
builder.Services.AddAuthorization();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddAuthentication().AddCookie(IdentityConstants.ApplicationScheme);

builder.Services.AddIdentityCore<User>()
	.AddRoles<IdentityRole>()
	.AddEntityFrameworkStores<AppDbContext>()
	.AddSignInManager();

builder.Services.ConfigureApplicationCookie(opt =>
{
	opt.LoginPath = "/login";
	opt.AccessDeniedPath = "/access-denied";
});

/* Database */
builder.Services.AddDbContext<AppDbContext>(options =>
{
	options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection") ??
	                  throw new InvalidOperationException("Sorry, your connection is not found"));
});

/* Services */
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<ICriteriaService, CriteriaService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ITicketRepository, TicketRepository>();
builder.Services.AddScoped<ITicketService, TicketService>();
builder.Services.AddScoped(typeof(EncryptionHelper<>));

/*MudBlazor*/
builder.Services.AddMudServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error", true);
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorComponents<App>()
	.AddInteractiveServerRenderMode();

app.Run();