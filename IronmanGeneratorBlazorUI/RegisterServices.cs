namespace IronmanGeneratorBlazorUI;

public static class RegisterServices
{
    public static void ConfirgureServies(this WebApplicationBuilder builder)
    {
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();

    }
}
