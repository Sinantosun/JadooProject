using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Concrete;
using JadooProject.DataAccess.Context;

using JadooProject.DataAccess.Repositories;
using JadooProject.Features.CQRS.Handlers.BrandHandlers;
using JadooProject.Features.CQRS.Handlers.DashboardHandlers;
using JadooProject.Features.CQRS.Handlers.DestinationHandlers;
using JadooProject.Features.CQRS.Handlers.FeatureHandlers;
using JadooProject.Features.CQRS.Handlers.ManuelHandlers;
using JadooProject.Features.CQRS.Handlers.NewsLetterHandlers;
using JadooProject.Features.CQRS.Handlers.TestimonailHandlers;
using JadooProject.Features.CQRS.Results.BrandResults;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddDbContext<JadooContext>();

builder.Services.AddScoped<GetDestinationQueryHandler>();
builder.Services.AddScoped<GetDestinationByIdQueryHandler>();
builder.Services.AddScoped<CreateDestinationCommandHandler>();
builder.Services.AddScoped<RemoveDestinationCommandHandler>();
builder.Services.AddScoped<UpdateDestinationCommandHandler>();
builder.Services.AddScoped<GetDestinationForDashboardQueryHandler>();

builder.Services.AddScoped<GetFeatureQueryHandler>();
builder.Services.AddScoped<GetFeatureByIdQueryHandler>();
builder.Services.AddScoped<UpdateFeatureCommandHandler>();
builder.Services.AddScoped<CreateFeatureCommandHandler>();
builder.Services.AddScoped<RemoveFeatureCommandHandler>();

builder.Services.AddScoped<GetManuelQueryHandler>();
builder.Services.AddScoped<CreateManuelCommandHandler>();
builder.Services.AddScoped<GetManuelByIdQueryHandler>();
builder.Services.AddScoped<UpdateManuelCommandHandler>();
builder.Services.AddScoped<RemoveManuelCommandHandler>();

builder.Services.AddScoped<GetTestimonailQueryHandler>();
builder.Services.AddScoped<CreateTestimonailCommandHandler>();
builder.Services.AddScoped<GetTestimonialByIdQueryHandler>();
builder.Services.AddScoped<UpdateTestimonialCommandHandler>();
builder.Services.AddScoped<RemoveTestimonailCommandHandler>();
builder.Services.AddScoped<GetTestimonailForDashboradQueryHandler>();

builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<RemoveBrandCommandHandler>();

builder.Services.AddScoped<GetNewsLetterQueryHandler>();
builder.Services.AddScoped<UpdateNewsLetterCommandHandler>();
builder.Services.AddScoped<RemoveNewsLetterCommandHandler>();
builder.Services.AddScoped<GetNewsLetterByIdQueryHandler>();

builder.Services.AddScoped<ITestimonailDal,EFTestimonailDal>();
builder.Services.AddScoped<GetDashboardStatisticQueryHandler>();


builder.Services.AddScoped<INewsLetterDal,EFNewsLetterDal>();
builder.Services.AddScoped<IDestinationDal, EFDestinationDal>();
builder.Services.AddScoped<IServiceDal, EFServiceDal>();
builder.Services.AddScoped<IBrandDal, EFBrandDal>();
builder.Services.AddScoped<IFeatureDal, EFFeatureDal>();



builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
});



builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});



app.Run();
