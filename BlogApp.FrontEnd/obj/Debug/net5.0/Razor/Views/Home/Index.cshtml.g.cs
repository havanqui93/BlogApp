#pragma checksum "D:\Research\Net\BlogApp\BlogApp.FrontEnd\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d0de4c5828939b76b208a8aa0a8963905abd371"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Research\Net\BlogApp\BlogApp.FrontEnd\Views\_ViewImports.cshtml"
using BlogApp.FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Research\Net\BlogApp\BlogApp.FrontEnd\Views\_ViewImports.cshtml"
using BlogApp.FrontEnd.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d0de4c5828939b76b208a8aa0a8963905abd371", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ed352f44ea117c8bfc997242c7ae17909afaafd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Home/Index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Home/Post.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Research\Net\BlogApp\BlogApp.FrontEnd\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Blog Post";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""container-fluid layout-default main-container"">
    <div class=""page-content"">
        <div class=""content-left""></div>
        <div class=""content-center"">
            <!-- create post -->
            <div class=""create-post"">
                <div class=""static-section"">
                    <div class=""card-title"">
                        <h3>create post</h3>
                        <ul class=""create-option"">
                            <li class=""options"">
                                <div class=""setting-dropdown"">
                                    <div class=""btn-group custom-dropdown arrow-none dropdown-sm"">
                                        <h5 data-bs-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">public <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-chevron-down iw-14""><polyline points=""6 9 12 15 ");
            WriteLiteral(@"18 9""></polyline></svg></h5>
                                        <div class=""dropdown-menu dropdown-menu-right custom-dropdown"">
                                            <ul>
                                                <li>
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 1427, "\"", 1434, 0);
            EndWriteAttribute();
            WriteLiteral(@"><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-globe icon-font-light iw-16 ih-16""><circle cx=""12"" cy=""12"" r=""10""></circle><line x1=""2"" y1=""12"" x2=""22"" y2=""12""></line><path d=""M12 2a15.3 15.3 0 0 1 4 10 15.3 15.3 0 0 1-4 10 15.3 15.3 0 0 1-4-10 15.3 15.3 0 0 1 4-10z""></path></svg>public</a>
                                                </li>
                                                <li>
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 2048, "\"", 2055, 0);
            EndWriteAttribute();
            WriteLiteral(@"><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-users icon-font-light iw-16 ih-16""><path d=""M17 21v-2a4 4 0 0 0-4-4H5a4 4 0 0 0-4 4v2""></path><circle cx=""9"" cy=""7"" r=""4""></circle><path d=""M23 21v-2a4 4 0 0 0-3-3.87""></path><path d=""M16 3.13a4 4 0 0 1 0 7.75""></path></svg>friends</a>
                                                </li>
                                                <li>
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 2661, "\"", 2668, 0);
            EndWriteAttribute();
            WriteLiteral(@"><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-lock icon-font-light iw-16 ih-16""><rect x=""3"" y=""11"" width=""18"" height=""11"" rx=""2"" ry=""2""></rect><path d=""M7 11V7a5 5 0 0 1 10 0v4""></path></svg>only me</a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </li>
                        </ul>
                        <div class=""settings""></div>
                    </div>
                    <div class=""input-style icon-right form-control post-content-wrapper"">
                        <div class=""post-body beautiful-scroll form-editor"" contenteditable=""true"" dir=""ltr"" placeholder=""Write something..."" spellcheck=""false"" autocomplete=""off"" aut");
            WriteLiteral(@"ocorrect=""off"" autocapitalize=""off""></div>
                    </div>
                </div>
                <div class=""options-input"" id=""additional-input"">
                    <a id=""icon-close"" href=""javascript:void(0)"">
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-x iw-15 icon-font-light icon-close""><line x1=""18"" y1=""6"" x2=""6"" y2=""18""></line><line x1=""6"" y1=""6"" x2=""18"" y2=""18""></line></svg>
                    </a>
                </div>
                <ul class=""create-btm-option"">
                    <li class=""option-upload-file"">
                        <input class=""choose-file"" type=""file"">
                        <h5><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feat");
            WriteLiteral(@"her feather-camera iw-14""><path d=""M23 19a2 2 0 0 1-2 2H3a2 2 0 0 1-2-2V8a2 2 0 0 1 2-2h4l2-3h6l2 3h4a2 2 0 0 1 2 2z""></path><circle cx=""12"" cy=""13"" r=""4""></circle></svg>Album</h5>
                    </li>
                    <li class=""option-post"">
                        <h5><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-camera iw-14""><path d=""M23 19a2 2 0 0 1-2 2H3a2 2 0 0 1-2-2V8a2 2 0 0 1 2-2h4l2-3h6l2 3h4a2 2 0 0 1 2 2z""></path><circle cx=""12"" cy=""13"" r=""4""></circle></svg>Post</h5>
                    </li>
                </ul>
                <div id=""post-btn"" class=""post-btn d-none"">
                    <button disabled=""disabled"" class=""Disable"">post</button>
                </div>
            </div>
            <div class=""overlay-bg""></div>
            <div class=""post-panel infinite-loader-sec section-t-space"">
                ");
            WriteLiteral(@"<div class=""post-wrapper col-grid-box"" style=""display: block;"">
                    <div class=""post-title"">
                        <div class=""profile"">
                            <div class=""media"">
                                <a class=""popover-cls user-img bg-size blur-up lazyloaded"" data-bs-toggle=""popover"" data-placement=""right"" data-name=""sufiya eliza"" data-img=""https://themes.pixelstrap.com/friendbook/assets/images/user-sm/1.jpg"" style=""background-image: url(&quot;https://themes.pixelstrap.com/friendbook/assets/images/user-sm/1.jpg&quot;); background-size: cover; background-position: center center; background-repeat: no-repeat; display: block;"" data-bs-original-title=""""");
            BeginWriteAttribute("title", " title=\"", 6436, "\"", 6444, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <img src=""https://themes.pixelstrap.com/friendbook/assets/images/user-sm/1.jpg"" class=""img-fluid blur-up lazyload bg-img"" alt=""user"" style=""display: none;"">
                                </a>
                                <div class=""media-body"">
                                    <a href=""#"">
                                        <h5>sufiya eliza</h5>
                                    </a>
                                    <h6>30 mins ago</h6>
                                </div>
                            </div>
                        </div>
                        <div class=""setting-btn ms-auto setting-dropdown no-bg"">
                            <div class=""btn-group custom-dropdown arrow-none dropdown-sm"">
                                <div role=""button"" data-bs-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24");
            WriteLiteral(@" 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-more-horizontal icon icon-font-color iw-14""><circle cx=""12"" cy=""12"" r=""1""></circle><circle cx=""19"" cy=""12"" r=""1""></circle><circle cx=""5"" cy=""12"" r=""1""></circle></svg>
                                </div>
                                <div class=""dropdown-menu dropdown-menu-right custom-dropdown"">
                                    <ul>
                                        <li>
                                            <a");
            BeginWriteAttribute("href", " href=\"", 8034, "\"", 8041, 0);
            EndWriteAttribute();
            WriteLiteral(@"><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-bookmark icon-font-light iw-16 ih-16""><path d=""M19 21l-7-5-7 5V5a2 2 0 0 1 2-2h10a2 2 0 0 1 2 2z""></path></svg>save post</a>
                                        </li>
                                        <li>
                                            <a");
            BeginWriteAttribute("href", " href=\"", 8512, "\"", 8519, 0);
            EndWriteAttribute();
            WriteLiteral(@"><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-x-square icon-font-light iw-16 ih-16""><rect x=""3"" y=""3"" width=""18"" height=""18"" rx=""2"" ry=""2""></rect><line x1=""9"" y1=""9"" x2=""15"" y2=""15""></line><line x1=""15"" y1=""9"" x2=""9"" y2=""15""></line></svg>hide post</a>
                                        </li>
                                        <li>
                                            <a");
            BeginWriteAttribute("href", " href=\"", 9071, "\"", 9078, 0);
            EndWriteAttribute();
            WriteLiteral(@"><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-x-octagon icon-font-light iw-16 ih-16""><polygon points=""7.86 2 16.14 2 22 7.86 22 16.14 16.14 22 7.86 22 2 16.14 2 7.86 7.86 2""></polygon><line x1=""15"" y1=""9"" x2=""9"" y2=""15""></line><line x1=""9"" y1=""9"" x2=""15"" y2=""15""></line></svg>unfollow sufiya</a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""post-details"">
                        <div class=""img-wrapper"">
                            <img src=""https://themes.pixelstrap.com/friendbook/assets/images/post/1.jpg"" class=""img-fluid blur-up lazyloaded""");
            BeginWriteAttribute("alt", " alt=\"", 10001, "\"", 10007, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""detail-box"">
                            <p class=""detail-box-description"">
                                Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                                has been the industry's standard dummy text ever since the 1500s
                            </p>
                            <div class=""people-likes"">
                                <ul>
                                    <li class=""popover-cls bg-size blur-up lazyloaded"" data-bs-toggle=""popover"" data-placement=""right"" data-name=""sufiya eliza"" data-img=""https://themes.pixelstrap.com/friendbook/assets/images/user-sm/1.jpg"" style=""background-image: url(&quot;https://themes.pixelstrap.com/friendbook/assets/images/user-sm/1.jpg&quot;); background-size: cover; background-position: center center; background-repeat: no-repeat; display: block;"" data-bs-original-title=""""");
            BeginWriteAttribute("title", " title=\"", 10975, "\"", 10983, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <img src=\"https://themes.pixelstrap.com/friendbook/assets/images/user-sm/1.jpg\" class=\"img-fluid blur-up lazyload bg-img\"");
            BeginWriteAttribute("alt", " alt=\"", 11148, "\"", 11154, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""display: none;"">
                                    </li>
                                    <li class=""popover-cls bg-size blur-up lazyloaded"" data-bs-toggle=""popover"" data-placement=""right"" data-name=""sufiya eliza"" data-img=""https://themes.pixelstrap.com/friendbook/assets/images/user-sm/2.jpg"" style=""background-image: url(&quot;https://themes.pixelstrap.com/friendbook/assets/images/user-sm/2.jpg&quot;); background-size: cover; background-position: center center; background-repeat: no-repeat; display: block;"" data-bs-original-title=""""");
            BeginWriteAttribute("title", " title=\"", 11708, "\"", 11716, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <img src=\"https://themes.pixelstrap.com/friendbook/assets/images/user-sm/2.jpg\" class=\"img-fluid blur-up lazyload bg-img\"");
            BeginWriteAttribute("alt", " alt=\"", 11881, "\"", 11887, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""display: none;"">
                                    </li>
                                    <li class=""popover-cls bg-size blur-up lazyloaded"" data-bs-toggle=""popover"" data-placement=""right"" data-name=""sufiya eliza"" data-img=""https://themes.pixelstrap.com/friendbook/assets/images/user-sm/3.jpg"" style=""background-image: url(&quot;https://themes.pixelstrap.com/friendbook/assets/images/user-sm/3.jpg&quot;); background-size: cover; background-position: center center; background-repeat: no-repeat; display: block;"" data-bs-original-title=""""");
            BeginWriteAttribute("title", " title=\"", 12441, "\"", 12449, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <img src=\"https://themes.pixelstrap.com/friendbook/assets/images/user-sm/3.jpg\" class=\"img-fluid blur-up lazyload bg-img\"");
            BeginWriteAttribute("alt", " alt=\"", 12614, "\"", 12620, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""display: none;"">
                                    </li>
                                </ul>
                                <h6>+12 people react this post</h6>
                            </div>
                        </div>
                        <div class=""like-panel"">
                            <div class=""right-stats"">
                                <ul>
                                    <li>
                                        <h5>
                                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-message-square iw-16 ih-16""><path d=""M21 15a2 2 0 0 1-2 2H7l-4 4V5a2 2 0 0 1 2-2h14a2 2 0 0 1 2 2z""></path></svg>
                                            <span>4565</span> comment
                                        </h5>
                                    </li>
                        ");
            WriteLiteral(@"            <li>
                                        <h5>
                                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-share iw-16 ih-16""><path d=""M4 12v8a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2v-8""></path><polyline points=""16 6 12 2 8 6""></polyline><line x1=""12"" y1=""2"" x2=""12"" y2=""15""></line></svg><span>985</span>
                                            share
                                        </h5>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <div class=""post-react"">
                            <ul>
                                <li class=""react-btn"">
                                    <a class=""react-click"" href=""javascript:void(0)"">
                                        <svg xm");
            WriteLiteral(@"lns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-smile iw-18 ih-18""><circle cx=""12"" cy=""12"" r=""10""></circle><path d=""M8 14s1.5 2 4 2 4-2 4-2""></path><line x1=""9"" y1=""9"" x2=""9.01"" y2=""9""></line><line x1=""15"" y1=""9"" x2=""15.01"" y2=""9""></line></svg> react
                                    </a>
                                    <div class=""react-box"">
                                        <ul>
                                            <li data-title=""smile"">
                                                <a href=""javascript:void(0)"">
                                                    <img src=""https://themes.pixelstrap.com/friendbook/assets/svg/emoji/040.svg"" alt=""smile"">
                                                </a>
                                            </li>
                                            <li data-title=""love"">
          ");
            WriteLiteral(@"                                      <a href=""javascript:void(0)"">
                                                    <img src=""https://themes.pixelstrap.com/friendbook/assets/svg/emoji/113.svg"" alt=""heart"">
                                                </a>
                                            </li>
                                            <li data-title=""cry"">
                                                <a href=""javascript:void(0)"">
                                                    <img src=""https://themes.pixelstrap.com/friendbook/assets/svg/emoji/027.svg"" alt=""cry"">
                                                </a>
                                            </li>
                                            <li data-title=""wow"">
                                                <a href=""javascript:void(0)"">
                                                    <img src=""https://themes.pixelstrap.com/friendbook/assets/svg/emoji/052.svg"" alt=""angry"">
                          ");
            WriteLiteral(@"                      </a>
                                            </li>
                                            <li data-title=""angry"">
                                                <a href=""javascript:void(0)"">
                                                    <img src=""https://themes.pixelstrap.com/friendbook/assets/svg/emoji/039.svg"" alt=""angry"">
                                                </a>
                                            </li>
                                            <li data-title=""haha"">
                                                <a href=""javascript:void(0)"">
                                                    <img src=""https://themes.pixelstrap.com/friendbook/assets/svg/emoji/042.svg""");
            BeginWriteAttribute("alt", " alt=\"", 17467, "\"", 17473, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                </a>
                                            </li>
                                        </ul>
                                    </div>
                                </li>
                                <li class=""comment-click"">
                                    <a href=""javascript:void(0)"">
                                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-message-square iw-18 ih-18""><path d=""M21 15a2 2 0 0 1-2 2H7l-4 4V5a2 2 0 0 1 2-2h14a2 2 0 0 1 2 2z""></path></svg> comment
                                    </a>
                                </li>
                                <li data-bs-target=""#shareModal"" data-bs-toggle=""modal"">
                                    <a href=""javascript:void(0)"">
                                        <svg xmlns=""ht");
            WriteLiteral(@"tp://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-share iw-16 ih-16""><path d=""M4 12v8a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2v-8""></path><polyline points=""16 6 12 2 8 6""></polyline><line x1=""12"" y1=""2"" x2=""12"" y2=""15""></line></svg> share
                                    </a>
                                </li>
                            </ul>
                        </div>
                        <div class=""comment-section"">
                            <div class=""reply"">
                                <div class=""search-input input-style input-lg icon-right"">
                                    <div class=""emojionearea form-control emojiPicker emojionearea-inline"">
                                        <div class=""emojionearea-editor beautiful-scroll form-editor"" contenteditable=""true"" placeholder=""Write a comment.."" tabindex=""0"" dir=""ltr"" spellcheck=""false"" au");
            WriteLiteral(@"tocomplete=""off"" autocorrect=""off"" autocapitalize=""off""></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div id=""load-more"" class=""post-loader"">
                <div class=""loader-icon"">
                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-rotate-ccw icon-theme iw-25 ih-25""><polyline points=""1 4 1 10 7 10""></polyline><path d=""M3.51 15a9 9 0 1 0 2.13-9.36L1 10""></path></svg>
                </div>
                <div class=""no-more-text"">
                    <p>no more post</p>
                </div>
            </div>
        </div>
        <div class=""content-right""></div>

    </div>
</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d0de4c5828939b76b208a8aa0a8963905abd37127702", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d0de4c5828939b76b208a8aa0a8963905abd37128802", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
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
