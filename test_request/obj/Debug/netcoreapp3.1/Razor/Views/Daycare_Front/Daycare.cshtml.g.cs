#pragma checksum "C:\Users\solta\Documents\Pi\JrdnEnft-Platform\test_request\Views\Daycare_Front\Daycare.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e64a3e4cdfd2364c579d7ef570217f9dd6ae5d6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Daycare_Front_Daycare), @"mvc.1.0.view", @"/Views/Daycare_Front/Daycare.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\solta\Documents\Pi\JrdnEnft-Platform\test_request\Views\_ViewImports.cshtml"
using test_request;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\solta\Documents\Pi\JrdnEnft-Platform\test_request\Views\_ViewImports.cshtml"
using test_request.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e64a3e4cdfd2364c579d7ef570217f9dd6ae5d6c", @"/Views/Daycare_Front/Daycare.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63a780b60ef5feef578cd0f9095c8d70019a889b", @"/Views/_ViewImports.cshtml")]
    public class Views_Daycare_Front_Daycare : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("newsletter-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e64a3e4cdfd2364c579d7ef570217f9dd6ae5d6c4085", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <title>Shelly School HTML Template</title>
    <meta name=""viewport"" content=""width=device-width,initial-scale=1"">
    <meta name=""description"" content=""Shelly - Website"">
    <meta name=""author"" content=""merkulove"">
    <meta name=""keywords""");
                BeginWriteAttribute("content", " content=\"", 313, "\"", 323, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <link rel=\"icon\" href=\"assets/img/favicon.png\">\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"assets/css/main.min.css\">\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"assets/css/button.min.css\">\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e64a3e4cdfd2364c579d7ef570217f9dd6ae5d6c5718", async() => {
                WriteLiteral("\n    <div class=\"wrapper\">\n        <header>\n            <div class=\"container\">\n                <div class=\"header-content d-flex flex-wrap align-items-center\">\n                    <div class=\"logo\"><a href=\"index.html\"");
                BeginWriteAttribute("title", " title=\"", 763, "\"", 771, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"assets/img/logo.png\"");
                BeginWriteAttribute("alt", " alt=\"", 803, "\"", 809, 0);
                EndWriteAttribute();
                WriteLiteral(@" srcset=""assets/img/01_Logo_2x.png 2x""></a></div>
                    <!--logo end-->
                    <ul class=""contact-add d-flex flex-wrap"">
                        <li>
                            <div class=""contact-info"">
                                <img src=""assets/img/icon1.png""");
                BeginWriteAttribute("alt", " alt=\"", 1105, "\"", 1111, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                <div class=""contact-tt"">
                                    <h4>Call</h4>
                                    <span>+2 342 5446 67</span>
                                </div>
                            </div>
                            <!--contact-info end-->
                        </li>
                        <li>
                            <div class=""contact-info"">
                                <img src=""assets/img/icon2.png""");
                BeginWriteAttribute("alt", " alt=\"", 1588, "\"", 1594, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                <div class=""contact-tt"">
                                    <h4>Work Time</h4>
                                    <span>Mon - Fri 8 AM - 5 PM</span>
                                </div>
                            </div>
                            <!--contact-info end-->
                        </li>
                        <li>
                            <div class=""contact-info"">
                                <img src=""assets/img/icon3.png""");
                BeginWriteAttribute("alt", " alt=\"", 2083, "\"", 2089, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                <div class=""contact-tt"">
                                    <h4>Address</h4>
                                    <span>Franklin St, Greenpoint Ave</span>
                                </div>
                            </div>
                            <!--contact-info end-->
                        </li>
                    </ul>
                    <!--contact-information end-->
                    <div class=""menu-btn""><a href=""#""><span class=""bar1""></span> <span class=""bar2""></span> <span class=""bar3""></span></a></div>
                    <!--menu-btn end-->
                </div>
                <!--header-content end-->
                <div class=""navigation-bar d-flex flex-wrap align-items-center"">
                    <nav>
                        <ul>
                            <li><a class=""active"" href=""index.html""");
                BeginWriteAttribute("title", " title=\"", 2965, "\"", 2973, 0);
                EndWriteAttribute();
                WriteLiteral(">Home</a></li>\n                            <li>\n                                <a href=\"about.html\"");
                BeginWriteAttribute("title", " title=\"", 3074, "\"", 3082, 0);
                EndWriteAttribute();
                WriteLiteral(">About</a>\n                                <ul>\n                                    <li><a href=\"events.html\"");
                BeginWriteAttribute("title", " title=\"", 3192, "\"", 3200, 0);
                EndWriteAttribute();
                WriteLiteral(">Events</a></li>\n                                    <li><a href=\"event-single.html\"");
                BeginWriteAttribute("title", " title=\"", 3285, "\"", 3293, 0);
                EndWriteAttribute();
                WriteLiteral(">Event Single</a></li>\n                                    <li><a href=\"schedule.html\"");
                BeginWriteAttribute("title", " title=\"", 3380, "\"", 3388, 0);
                EndWriteAttribute();
                WriteLiteral(">Schedule</a></li>\n                                    <li><a href=\"error.html\"");
                BeginWriteAttribute("title", " title=\"", 3468, "\"", 3476, 0);
                EndWriteAttribute();
                WriteLiteral(">404</a></li>\n                                </ul>\n                            </li>\n                            <li>\n                                <a class=\"active\" href=\"classes.html\"");
                BeginWriteAttribute("title", " title=\"", 3665, "\"", 3673, 0);
                EndWriteAttribute();
                WriteLiteral(">Classes</a>\n                                <ul>\n                                    <li><a href=\"class-single.html\"");
                BeginWriteAttribute("title", " title=\"", 3791, "\"", 3799, 0);
                EndWriteAttribute();
                WriteLiteral(">Class Single</a></li>\n                                </ul>\n                            </li>\n                            <li>\n                                <a href=\"teachers.html\"");
                BeginWriteAttribute("title", " title=\"", 3983, "\"", 3991, 0);
                EndWriteAttribute();
                WriteLiteral(">Teachers</a>\n                                <ul>\n                                    <li><a href=\"teacher-single.html\"");
                BeginWriteAttribute("title", " title=\"", 4112, "\"", 4120, 0);
                EndWriteAttribute();
                WriteLiteral(">Teacher Single</a></li>\n                                </ul>\n                            </li>\n                            <li>\n                                <a href=\"blog.html\"");
                BeginWriteAttribute("title", " title=\"", 4302, "\"", 4310, 0);
                EndWriteAttribute();
                WriteLiteral(">Blog</a>\n                                <ul>\n                                    <li><a href=\"post.html\"");
                BeginWriteAttribute("title", " title=\"", 4417, "\"", 4425, 0);
                EndWriteAttribute();
                WriteLiteral(">Blog Single</a></li>\n                                </ul>\n                            </li>\n                            <li><a href=\"contacts.html\"");
                BeginWriteAttribute("title", " title=\"", 4575, "\"", 4583, 0);
                EndWriteAttribute();
                WriteLiteral(">Contacts</a></li>\n                        </ul>\n                    </nav>\n                    <!--nav end-->\n                    <ul class=\"social-links ml-auto\">\n                        <li><a href=\"#\"");
                BeginWriteAttribute("title", " title=\"", 4788, "\"", 4796, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fab fa-facebook-f\"></i></a></li>\n                        <li><a href=\"#\"");
                BeginWriteAttribute("title", " title=\"", 4880, "\"", 4888, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fab fa-linkedin-in\"></i></a></li>\n                        <li><a href=\"#\"");
                BeginWriteAttribute("title", " title=\"", 4973, "\"", 4981, 0);
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fab fa-instagram""></i></a></li>
                    </ul>
                </div>
                <!--navigation-bar end-->
            </div>
        </header>
        <!--header end-->
        <div class=""responsive-menu"">
            <ul>
                <li><a href=""index.html""");
                BeginWriteAttribute("title", " title=\"", 5274, "\"", 5282, 0);
                EndWriteAttribute();
                WriteLiteral(">Home</a></li>\n                <li><a href=\"about.html\"");
                BeginWriteAttribute("title", " title=\"", 5338, "\"", 5346, 0);
                EndWriteAttribute();
                WriteLiteral(">About</a></li>\n                <li><a href=\"events.html\"");
                BeginWriteAttribute("title", " title=\"", 5404, "\"", 5412, 0);
                EndWriteAttribute();
                WriteLiteral(">Events</a></li>\n                <li><a href=\"event-single.html\"");
                BeginWriteAttribute("title", " title=\"", 5477, "\"", 5485, 0);
                EndWriteAttribute();
                WriteLiteral(">Event Single</a></li>\n                <li><a href=\"schedule.html\"");
                BeginWriteAttribute("title", " title=\"", 5552, "\"", 5560, 0);
                EndWriteAttribute();
                WriteLiteral(">Schedule</a></li>\n                <li><a href=\"classes.html\"");
                BeginWriteAttribute("title", " title=\"", 5622, "\"", 5630, 0);
                EndWriteAttribute();
                WriteLiteral(">Classes</a></li>\n                <li><a href=\"class-single.html\"");
                BeginWriteAttribute("title", " title=\"", 5696, "\"", 5704, 0);
                EndWriteAttribute();
                WriteLiteral(">Classe Single</a></li>\n                <li><a href=\"teachers.html\"");
                BeginWriteAttribute("title", " title=\"", 5772, "\"", 5780, 0);
                EndWriteAttribute();
                WriteLiteral(">Teachers</a></li>\n                <li><a href=\"teacher-single.html\"");
                BeginWriteAttribute("title", " title=\"", 5849, "\"", 5857, 0);
                EndWriteAttribute();
                WriteLiteral(">Teacher Single</a></li>\n                <li><a href=\"blog.html\"");
                BeginWriteAttribute("title", " title=\"", 5922, "\"", 5930, 0);
                EndWriteAttribute();
                WriteLiteral(">Blog</a></li>\n                <li><a href=\"post.html\"");
                BeginWriteAttribute("title", " title=\"", 5985, "\"", 5993, 0);
                EndWriteAttribute();
                WriteLiteral(">Blog Single</a></li>\n                <li><a href=\"contacts.html\"");
                BeginWriteAttribute("title", " title=\"", 6059, "\"", 6067, 0);
                EndWriteAttribute();
                WriteLiteral(">Contacts</a></li>\n                <li><a href=\"error.html\"");
                BeginWriteAttribute("title", " title=\"", 6127, "\"", 6135, 0);
                EndWriteAttribute();
                WriteLiteral(">404</a></li>\n            </ul>\n        </div>\n        <!--responsive-menu end-->\n        <section class=\"class-single-banner\"><img src=\"assets/img/class-single-banner.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 6308, "\"", 6314, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""w-100""></section>
        <!--class-single-banner end-->
        <section class=""page-content style2"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xl-8 col-lg-8"">
                        <div class=""class-single-content"">
                            <h2>");
#nullable restore
#line 128 "C:\Users\solta\Documents\Pi\JrdnEnft-Platform\test_request\Views\Daycare_Front\Daycare.cshtml"
                           Write(ViewBag.daycare["daycareName"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\n                            <ul class=\"meta-box\">\n                                <li><a href=\"/Daycare_Front\"");
                BeginWriteAttribute("title", " title=\"", 6786, "\"", 6794, 0);
                EndWriteAttribute();
                WriteLiteral(@">Home</a></li>
                                <li><span>Classes</span></li>
                            </ul>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce vel venenatis felis. Fusce id lectus sit amet nisi ornare ultricies. In sagittis lacinia lorem et tristique. Quisque mauris neque, sollicitudin sit amet imperdiet in, scelerisque sit amet arcu. In vehicula sem eget nisi convallis, a mattis orci imperdiet. Curabitur vitae sapien vel lectus sagittis consequat. Nullam enim velit, dignissim vel viverra ac, eleifend ut tellus.</p>
                            <p>Nunc at tincidunt nisl. Nullam fringilla quis odio vitae eleifend. Quisque sed mi erat. In hac habitasse platea dictumst. Vivamus mattis nunc quis turpis pretium sollicitudin. In eu semper justo. Phasellus facilisis hendrerit massa, sed auctor lacus convallis et. Vestibulum ac odio interdum, efficitur nisl ut, sollicitudin arcu. Donec commodo elementum tempus. In hac habitasse platea dictumst.</p>

       ");
                WriteLiteral("                     <!--class-gallery end-->\n                            <h3>Published Posts</h3>\n                            <div class=\"class-gallery\">\n                                <div class=\"row\">\n");
#nullable restore
#line 140 "C:\Users\solta\Documents\Pi\JrdnEnft-Platform\test_request\Views\Daycare_Front\Daycare.cshtml"
                                     foreach (var post in ViewBag.posts)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"col-lg-3 col-md-3 col-sm-3 col-3\">\n                            <div class=\"class-gallery-img\">\n                                <a");
                BeginWriteAttribute("href", " href=\"", 8300, "\"", 8335, 2);
                WriteAttributeValue("", 8307, "/Post_Front/Post/", 8307, 17, true);
#nullable restore
#line 144 "C:\Users\solta\Documents\Pi\JrdnEnft-Platform\test_request\Views\Daycare_Front\Daycare.cshtml"
WriteAttributeValue("", 8324, post["id"], 8324, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 8336, "\"", 8344, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"html5lightbox\" data-group=\"set1\">\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 8427, "\"", 8447, 1);
#nullable restore
#line 145 "C:\Users\solta\Documents\Pi\JrdnEnft-Platform\test_request\Views\Daycare_Front\Daycare.cshtml"
WriteAttributeValue("", 8433, post["media"], 8433, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 8448, "\"", 8454, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"height: 7rem;\">\n                                    <p>");
#nullable restore
#line 146 "C:\Users\solta\Documents\Pi\JrdnEnft-Platform\test_request\Views\Daycare_Front\Daycare.cshtml"
                                  Write(post["title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                                </a>\n                            </div>\n                            <!--class-gallery-img end-->\n                        </div>");
#nullable restore
#line 150 "C:\Users\solta\Documents\Pi\JrdnEnft-Platform\test_request\Views\Daycare_Front\Daycare.cshtml"
                              }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </div>\n                                <!--class-gallery-img end-->\n                            </div>\n                            <a href=\"classes.html\"");
                BeginWriteAttribute("title", " title=\"", 8884, "\"", 8892, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn-default\">Enroll Now<i class=\"fa fa-long-arrow-alt-right\"></i></a>\n                            <a href=\"classes.html\"");
                BeginWriteAttribute("title", " title=\"", 9021, "\"", 9029, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""btn-default"">Add to Favorite<i class=""fa fa-long-arrow-alt-right""></i></a>
                        </div>
                        <!--class-single-content end-->
                    </div>
                    <div class=""col-xl-4 col-lg-4"">
                        <div class=""sidebar class-sidebar"">
                            <div class=""widget widget-information"">
                                <h3 class=""widget-title"">Daycare Information</h3>
                                <ul>
                                    <li>
                                        <h4>Region</h4>
                                        <span>");
#nullable restore
#line 167 "C:\Users\solta\Documents\Pi\JrdnEnft-Platform\test_request\Views\Daycare_Front\Daycare.cshtml"
                                         Write(ViewBag.daycare["region"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                                    </li>\n                                    <li>\n                                        <h4>Reputation</h4>\n                                        <span>");
#nullable restore
#line 171 "C:\Users\solta\Documents\Pi\JrdnEnft-Platform\test_request\Views\Daycare_Front\Daycare.cshtml"
                                         Write(ViewBag.daycare["reputation"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                                    </li>\n                                    <li>\n                                        <a class=\"btn-default\"");
                BeginWriteAttribute("href", " href=\"", 10075, "\"", 10241, 5);
                WriteAttributeValue("", 10082, "https://www.google.com/maps/search/", 10082, 35, true);
#nullable restore
#line 174 "C:\Users\solta\Documents\Pi\JrdnEnft-Platform\test_request\Views\Daycare_Front\Daycare.cshtml"
WriteAttributeValue("", 10117, ViewBag.daycare["position"]["x"], 10117, 33, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 10150, ",", 10150, 1, true);
#nullable restore
#line 174 "C:\Users\solta\Documents\Pi\JrdnEnft-Platform\test_request\Views\Daycare_Front\Daycare.cshtml"
WriteAttributeValue("", 10151, ViewBag.daycare["position"]["y"], 10151, 33, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 10184, "?sa=X&ved=2ahUKEwjPx4HuxsbvAhUJC-wKHQeiCzwQ8gEwAHoECAIQAQ", 10184, 57, true);
                EndWriteAttribute();
                WriteLiteral(@">Google Maps <i class=""fa fa-long-arrow-alt-right""></i></a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <!--sidebar end-->
                    </div>
                </div>
            </div>
        </section>
        <!--page-content end-->
        <section class=""newsletter-section"">
            <div class=""container"">
                <div class=""newsletter-sec"">
                    <div class=""row align-items-center"">
                        <div class=""col-lg-4"">
                            <div class=""newsz-ltr-text"">
                                <h2>Join us<br>and stay tuned!</h2>
                                <a href=""contacts.html""");
                BeginWriteAttribute("title", " title=\"", 11021, "\"", 11029, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""btn-default"">Join Us <i class=""fa fa-long-arrow-alt-right""></i></a>
                            </div>
                            <!--newsz-ltr-text end-->
                        </div>
                        <div class=""col-lg-8"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e64a3e4cdfd2364c579d7ef570217f9dd6ae5d6c26006", async() => {
                    WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col-md-4"">
                                        <div class=""form-group""><input type=""text"" name=""name"" placeholder=""Name""></div>
                                        <!--form-group end-->
                                    </div>
                                    <div class=""col-md-4"">
                                        <div class=""form-group""><input type=""email"" name=""email"" placeholder=""Email""></div>
                                        <!--form-group end-->
                                    </div>
                                    <div class=""col-md-4"">
                                        <div class=""form-group select-tg"">
                                            <select>
                                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e64a3e4cdfd2364c579d7ef570217f9dd6ae5d6c27155", async() => {
                        WriteLiteral("Class");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e64a3e4cdfd2364c579d7ef570217f9dd6ae5d6c28271", async() => {
                        WriteLiteral("Class");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e64a3e4cdfd2364c579d7ef570217f9dd6ae5d6c29387", async() => {
                        WriteLiteral("Class");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e64a3e4cdfd2364c579d7ef570217f9dd6ae5d6c30503", async() => {
                        WriteLiteral("Class");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e64a3e4cdfd2364c579d7ef570217f9dd6ae5d6c31619", async() => {
                        WriteLiteral("Class");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e64a3e4cdfd2364c579d7ef570217f9dd6ae5d6c32735", async() => {
                        WriteLiteral("Class");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                                            </select>
                                        </div>
                                        <!--form-group end-->
                                    </div>
                                    <div class=""col-md-12"">
                                        <div class=""form-group""><textarea name=""message"" placeholder=""Message""></textarea></div>
                                        <!--form-group end-->
                                    </div>
                                </div>
                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            <!--newsletter-form end-->\n                        </div>\n                    </div>\n                </div>\n                <!--newsletter-sec end-->\n            </div>\n        </section>\n        ");
#nullable restore
#line 233 "C:\Users\solta\Documents\Pi\JrdnEnft-Platform\test_request\Views\Daycare_Front\Daycare.cshtml"
   Write(Html.Partial("~/Views/Shared/footer.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </div>
    <script src=""assets/js/bundle.min.js""></script>
    <script src=""assets/js/button.min.js""></script><!-- Global site tag (gtag.js) - Google Analytics -->
    <script async src=""https://www.googletagmanager.com/gtag/js?id=UA-180910402-1""></script>
    <script>
    window.dataLayer = window.dataLayer || [];
        function gtag() { dataLayer.push(arguments); }
        gtag('js', new Date());
        gtag('config', 'UA-180910402-1');</script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
