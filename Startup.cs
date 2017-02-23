using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ConsoleApplication
{
    public class Startup
    {
       
        public void Configure(IApplicationBuilder app)
        {
    app.UseStaticFiles();
            
            app.Run(
                context =>{return context.Response.WriteAsync("Brug index.html for at vise hjemmesiden");}
            );

            
        }
        
    }
}
