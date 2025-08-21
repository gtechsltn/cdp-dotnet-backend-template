using Microsoft.AspNetCore.Builder;

namespace CdpDotnetBackendTemplate.Test.Config;

public class EnvironmentTest
{

   [Fact]
   public void IsNotDevModeByDefault()
   { 
       var builder = WebApplication.CreateEmptyBuilder(new WebApplicationOptions());
       var isDev = CdpDotnetBackendTemplate.Config.Environment.IsDevMode(builder);
       Assert.False(isDev);
   }
}
