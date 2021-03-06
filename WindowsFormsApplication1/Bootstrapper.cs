﻿using Nancy;
using Nancy.Session;
using Nancy.Bootstrapper;
using Nancy.Conventions;
using System.Web.Routing;
using Nancy.TinyIoc;

namespace WindowsFormsApplication1
{
    class BootstrapperDefaultNancyBootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
  
            nancyConventions.StaticContentsConventions.Clear();
            nancyConventions.StaticContentsConventions.Add
            (StaticContentConventionBuilder.AddDirectory("css", "/content/css"));
            nancyConventions.StaticContentsConventions.Add
            (StaticContentConventionBuilder.AddDirectory("js", "/content/js"));
            nancyConventions.StaticContentsConventions.Add
            (StaticContentConventionBuilder.AddDirectory("images", "/content/img"));
            nancyConventions.StaticContentsConventions.Add
            (StaticContentConventionBuilder.AddDirectory("fonts", "/content/fonts"));
        }

        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);

            StaticConfiguration.EnableRequestTracing = true;
            StaticConfiguration.DisableErrorTraces = false;
            
           
        }

    }
  
}
