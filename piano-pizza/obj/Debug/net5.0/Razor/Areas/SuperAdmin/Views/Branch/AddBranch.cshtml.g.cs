#pragma checksum "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Branch\AddBranch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a58b91337c500b2e6f4db22bbe0d821e4e83d015"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SuperAdmin_Views_Branch_AddBranch), @"mvc.1.0.view", @"/Areas/SuperAdmin/Views/Branch/AddBranch.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a58b91337c500b2e6f4db22bbe0d821e4e83d015", @"/Areas/SuperAdmin/Views/Branch/AddBranch.cshtml")]
    public class Areas_SuperAdmin_Views_Branch_AddBranch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Branch\AddBranch.cshtml"
  
    Layout = "~/Areas/SuperAdmin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"content\">\r\n    <div class=\"block-header\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <h2>\r\n                    ");
#nullable restore
#line 10 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Branch\AddBranch.cshtml"
               Write(local.GetLocalizedHtmlString("AddBranch"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </h2>
            </div>
        </div>
    </div>
    <div class=""container-fluid"">
        <!-- Basic Validation -->
        <div class=""row clearfix"">
            <div class=""col-lg-12 col-md-12 col-sm-12"">
                <div class=""card"">
                    <div class=""body"">
                        <div id=""form_validation"" method=""POST"">
                            <div class=""Scriptcontent"">

                                <main>
                                    <form method=""POST"" name=""form-example-1"" id=""form-example-1"" class=""rounded"" enctype=""multipart/form-data"">
                                        <div style=""cursor:pointer"" class=""input-field "">
                                            <label class=""active"">");
#nullable restore
#line 27 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Branch\AddBranch.cshtml"
                                                             Write(local.GetLocalizedHtmlString("BranchPictures"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                            <div class=""input-images-1 rounded"" style=""padding-top: .5rem;""></div>
                                        </div>

                                    </form>
                                </main>

                            </div>
                            <!-- #END# File Upload | Drag & Drop OR With Click & Choose -->

                            <div class=""row mt-4"">
                                <div class=""col-md-3"">
                                    <div class=""form-group form-float"">
                                        <div class=""file-field input-field mt-0 pt-0"">
                                            <label>");
#nullable restore
#line 41 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Branch\AddBranch.cshtml"
                                              Write(local.GetLocalizedHtmlString("LogoUpload"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                            <input id=""file"" type=""file"" required>
                                        </div>
                                    </div>
                                </div>

                                <div class=""col-md-3"">
                                    <div class=""form-group form-float"">
                                        <label>>");
#nullable restore
#line 49 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Branch\AddBranch.cshtml"
                                           Write(local.GetLocalizedHtmlString("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                        <input type=""text"" class=""form-control"" placeholder=""Name.."" name=""name"" required>
                                    </div>
                                </div>

                                <div class=""col-md-3"">
                                    <div class=""form-group form-float"">
                                        <label>");
#nullable restore
#line 56 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Branch\AddBranch.cshtml"
                                          Write(local.GetLocalizedHtmlString("Phone"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                        <input type=""text"" class=""form-control"" placeholder=""Phone.."" required>
                                    </div>
                                </div>


                                <div class=""col-md-3"">
                                    <div class=""form-group form-float"">
                                        <label>");
#nullable restore
#line 64 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Branch\AddBranch.cshtml"
                                          Write(local.GetLocalizedHtmlString("Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                        <input type=""email"" class=""form-control"" placeholder=""E-mail"" required>
                                    </div>
                                </div>

                                <div class=""col-12 mt-2"">
                                    <div class=""form-group form-float"">
                                        <textarea class=""border-top-0 border-left-0 border-right-0 w-100"" rows=""4"" style=""outline:none;border-color:#eee!important"" placeholder=""Description""></textarea>
                                    </div>
                                </div>
                                <div class=""col-12 mt-2"">
                                    <div class=""form-group"">
                                        <label>");
#nullable restore
#line 76 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Branch\AddBranch.cshtml"
                                          Write(local.GetLocalizedHtmlString("MapLocation"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                        <div class=""input-group"">
                                            <input type=""hidden"" class=""form-control"" id=""lat"" value=""-33.878358"" />
                                            <input type=""hidden"" class=""form-control"" id=""lng"" value=""151.1835443"" />
                                            <input style=""width:90%;z-index:2147483647;"" id=""autocomplete_search"" name=""autocomplete_search"" type=""text"" class=""form-control rounded"" placeholder=""Search Location"" />

                                            <br />
                                            <div class=""form-group"" style=""width: 100%;"">
                                                <div id=""map"" style=""width:100%; height:400px;padding:10px;margin-top:10px;""></div>
                                                <button hidden id=""MyLocator"" style=""background-color: rgb(255, 255, 255);box-shadow: rgba(0, 0, 0, 0.3) 0px 1px 4px -1px;display: block;border: 0px;margin: 0px; paddin");
            WriteLiteral(@"g: 0px;text-transform: none;position: relative;cursor: pointer;user-select: none;overflow: hidden;width: 40px;height: 40px;top: -250px;float: right;right: 11px;"">
                                                </button>
                                            </div>
                                            <label id=""lab"" style="" position: relative;top: -69px;font-size: 16px;font-weight: 500;""></label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <button class=""btn btn-raised btn-primary btn-round waves-effect mb-4"" style=""float:right"" type=""submit"">");
#nullable restore
#line 93 "D:\repos\piano-pizza\piano-pizza\Areas\SuperAdmin\Views\Branch\AddBranch.cshtml"
                                                                                                                                Write(local.GetLocalizedHtmlString("SUBMIT"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- #END# Basic Validation -->

    </div>
</section>

<script async defer type=""text/javascript"" src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyCt7JTzt_AoYGTPLoHIwYt8vw0vkjErorc&libraries=places&callback=initMap""></script>
<script type=""text/javascript"">

    var marker;
    var map;
    var radius = 10000;

    var geocoder;
    function initMap() {
        search_lat = """";
        search_lng = """";
        formattedAddress = """";
        var input = document.getElementById('autocomplete_search');
        map = new google.maps.Map(document.getElementById('map'), {
            zoom: 11,
            center: { lat: -33.878358, lng: 151.1835443 }
        });
        // var geoloccontrol = new klokantech.GeolocationControl(map, 11);
        marker = new google.maps.Marker({
            map: map,
            draggable: true,
            zoom: 1");
            WriteLiteral(@"1,
            animation: google.maps.Animation.DROP,
            position: { lat: -33.878358, lng: 151.1835443 }
        });
        marker.addListener('click', toggleBounce);
        markerCoords(marker);
        geocoder = new google.maps.Geocoder();
        var autocomplete = new google.maps.places.Autocomplete(input);
        autocomplete.addListener('place_changed', function () {
            var place = autocomplete.getPlace();
            // place variable will have all the information you are looking for.
            $('#lat').val(place.geometry['location'].lat());
            $('#long').val(place.geometry['location'].lng());
            search_lat = place.geometry['location'].lat();
            search_lng = place.geometry['location'].lng();
            $(""#address"").html(place.formatted_address);
            $(""#autocomplete_search"").val(place.formatted_address);

            //setCountryStateCity(place, false);
            // SETTING LAT LNG
            $(""#lat"").val(search_lat);");
            WriteLiteral(@"
            $(""#lng"").val(search_lng);
            map = new google.maps.Map(document.getElementById('map'), {
                zoom: 18,
                center: { lat: search_lat, lng: search_lng }
            });
            marker = new google.maps.Marker({
                map: map,
                draggable: true,
                zoom: 18,
                animation: google.maps.Animation.DROP,
                position: { lat: search_lat, lng: search_lng }
            });
            marker.addListener('click', toggleBounce);
            markerCoords(marker);
            var latlng = new google.maps.LatLng(search_lat, search_lng);
            map.setCenter(latlng);
            console.log('init Map', search_lat);
        });
    }
    function toggleBounce() {
        if (marker.getAnimation() !== null) {
            marker.setAnimation(null);
        } else {
            marker.setAnimation(google.maps.Animation.BOUNCE);
        }
    }
    function markerCoords(markerobject) {");
            WriteLiteral(@"
        google.maps.event.addListener(markerobject, 'dragend', function (evt) {
            var newlat = evt.latLng.lat().toFixed(3);
            var newlng = evt.latLng.lng().toFixed(3);
            geocoder.geocode({
                latLng: new google.maps.LatLng(newlat, newlng)
            }, function (responses) {
                if (responses && responses.length > 0) {
                    //setCountryStateCity(responses, true);
                    $(""#address"").html(responses[0].formatted_address);
                    $(""#autocomplete_search"").val(responses[0].formatted_address);
                }
                else {
                    console.log('Cannot determine address at this location.');
                }
            });
            $(""#lat"").val(newlat);
            $(""#lng"").val(newlng);
            console.log(newlat, "" drag value"");

        });
    }
    $(""#MyLocator"").on(""click"", function () {
        getLocation();
    })
    function getLocation() {
        if");
            WriteLiteral(@" (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(showPosition);
        }
        else {
            var latitude = ""-33.878358"";
            var longitude = ""151.1835443"";
            $(""#lat"").val(""-33.878358"");
            $(""#lng"").val(""151.1835443"");
            map = new google.maps.Map(document.getElementById('map'), {
                zoom: 18,
                center: { lat: latitude, lng: longitude }
            });
            marker = new google.maps.Marker({
                map: map,
                draggable: true,
                zoom: 2,
                animation: google.maps.Animation.DROP,
                position: { lat: latitude, lng: longitude }
            });
            marker.addListener('click', toggleBounce);
            //radius = 1000;
            markerCoords(marker);
            var latlng = new google.maps.LatLng(latitude, longitude);
            map.setCenter(latlng);
            $(""#autocomplete_search"").val(map.formatted_a");
            WriteLiteral(@"ddress);
            alert(""Geolocation is not supported by this browser."");
        }
    }
    function showPosition(position) {
        map = new google.maps.Map(document.getElementById('map'), {
            zoom: 18,
            center: { lat: position.coords.latitude, lng: position.coords.longitude }
        });
        marker = new google.maps.Marker({
            map: map,
            draggable: true,
            zoom: 2,
            animation: google.maps.Animation.DROP,
            position: { lat: position.coords.latitude, lng: position.coords.longitude }
        });
        marker.addListener('click', toggleBounce);
        markerCoords(marker);
        var latlng = new google.maps.LatLng(position.coords.latitude, position.coords.longitude);
        map.setCenter(latlng);
        $(""#lat"").val(position.coords.latitude);
        $(""#lng"").val(position.coords.longitude);
        console.log(""Show position "", position.coords.latitude);
    }
</script>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public piano_pizza.Resources.LocalizationService local { get; private set; }
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
