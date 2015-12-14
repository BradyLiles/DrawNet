using System;
using System.IO;
using System.Reflection;
using System.Security.AccessControl;
using DrawNet.Draw.Core.Services.Email.Models;
using RazorEngine;
using RazorEngine.Configuration;
using RazorEngine.Templating;

namespace DrawNet.Draw.Core.Services.Email
{
    public class EmailService
    {
        public EmailService()
        {
            
        }


        /*      /// <summary>
                /// Razor preV3 - Deprecated
                /// </summary>
                /// <typeparam name="T"></typeparam>
                /// <param name="templatePath"></param>
                /// <param name="viewName"></param>
                /// <param name="model"></param>
                /// <returns></returns>
                public static string RenderPartialViewToString<T>( string templatePath, string viewName, T model )
                {
                    string text = System.IO.File.ReadAllText( Path.Combine( templatePath, viewName ) );
                    string renderedText = Razor.Parse( text, model );
                    return renderedText;
                }*/

        /*
                public static string RenderPartialViewToString<T>( string templatePath, string viewName, string templateName, T model )
                {
                    string template = File.ReadAllText( Path.Combine( templatePath, viewName ) );
                    string renderedText = Engine.Razor.RunCompile( template, templateName, typeof( T ), model );
                    return renderedText;
                }
        */
        
        public static string RenderPartialViewToString<T>( string fullTemplatePath, string templateName, T model )
        {
            string templateSource = File.ReadAllText( fullTemplatePath );
//            Engine.Razor.AddTemplate( "TemplateAlias", File.ReadAllText(ViewPath + "_Layout.cshtml" ));
            return Engine.Razor.RunCompile( templateSource, templateName, typeof(T), model );
        }

        public static string PasswordResetEmail(ResetPasswordEmail passwordResetEmail)
        {
            return RenderPartialViewToString(Path.Combine( ExecutionDirectoryPathName, "Services/Email/Views/" ) + "ResetPassword.cshtml", "TemplateAlias", passwordResetEmail );
        }

        public static string ExecutionDirectoryPathName => Path.GetDirectoryName(new System.Uri( Assembly.GetExecutingAssembly().CodeBase ).AbsolutePath);
        public static string ViewPath => Path.Combine(ExecutionDirectoryPathName, "Services/Email/Views/");
    }


}