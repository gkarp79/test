#pragma checksum "F:\2021클라우드가상화\test\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c652e356893eac5dd73be247855719fa56180053"
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
#line 1 "F:\2021클라우드가상화\test\Views\_ViewImports.cshtml"
using test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\2021클라우드가상화\test\Views\_ViewImports.cshtml"
using test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c652e356893eac5dd73be247855719fa56180053", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04aae2d41d7a1f2a1b7badf4f453e10febdd2915", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\2021클라우드가상화\test\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome Saturdaynoon!!!</h1>\r\n</div>\r\n<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c652e356893eac5dd73be247855719fa561800533376", async() => {
                WriteLiteral(@"
        <meta charset=""utf-8""/>
        <script type=""text/javascript"" src=""https://code.jquery.com/jquery-3.5.1.min.js""></script>
        <script>
      var html = [];
         $.getJSON('https://storageaccountkb1.blob.core.windows.net/test?sp=r&st=2021-05-10T14:12:51Z&se=2021-05-10T22:12:51Z&spr=https&sv=2020-02-10&sr=c&sig=rPcpto85mQ3Swl8OV6Ux9Jbvl8P%2B6%2BaHPdWagRiTJ7U%3D', function (data) {
            $.each(data, function (i,item) { // 업로드한 json 파일에서 총 8개의 자료를 불러온다.
               html.push(Number(item.latitude)); // 위도
               html.push(Number(item.longitude)); // 경도
               html.push(item.address); // 주소
                html.push(item.phone_number); // 전화번호
               html.push(item.agency_name); // 기관명
               html.push(item.weekday_oph); // 평일 영업시간
               html.push(item.saturday_oph); // 토요일 영업시간
                html.push(item.holiday_oph); // 공휴일 영업시간
            });
         });
   </script>
    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c652e356893eac5dd73be247855719fa561800535323", async() => {
                WriteLiteral(@"
        <div id=""map"" style=""width:100%;height:100vh;""></div>
        <script type=""text/javascript"" src=""//dapi.kakao.com/v2/maps/sdk.js?appkey=86fbdae310623cf7492b3866da2c53a1&libraries=clusterer""></script>
        <script>
            var mapContainer = document.getElementById('map'), // 지도를 표시할 div 
                mapOption = { 
                    center: new kakao.maps.LatLng(35.160159251669604, 129.03986197041587), // 지도의 중심좌표
                    level: 7 // 지도의 확대 레벨
                };
            // 지도를 표시할 div와  지도 옵션으로  지도를 생성합니다
            var map = new kakao.maps.Map(mapContainer, mapOption);

            // 지도에 교통정보를 표시하도록 지도타입을 추가합니다
          map.addOverlayMapTypeId(kakao.maps.MapTypeId.TRAFFIC);

            // 지도에 지형정보를 표시하도록 지도타입을 추가합니다
            map.addOverlayMapTypeId(kakao.maps.MapTypeId.TERRAIN);

            // 마커 클러스터러를 생성한다
            var clusterer = new kakao.maps.MarkerClusterer({
                map: map, // 마커들을 클러스터로 관리하고 표시할 지도 객체
                aver");
                WriteLiteral(@"ageCenter: true, // 클러스터에 포함된 마커들의 평균 위치를 클러스터 마커 위치로 설정
                minLevel: 10 // 클러스터 할 최소 지도 레벨
            });

            var markers = [];

            for(var i=0; i<html.length; i++){
                if(i%8==0){ // json 파일에서 불러올 8개의 항목들이 잘 추출되었다면 지도에 마커를 찍는다
                var markerPosition = new kakao.maps.LatLng(html[i], html[i+1]);

                // 마커를 생성한다
                var marker = new kakao.maps.Marker({
                    position: markerPosition
                });

                // 마커가 지도 위에 표시되도록 설정한다
                marker.setMap(map);
                var iwContent = ("" 주소: "" + html[i+2] + "" 전화번호: "" + html[i+3] + "" 기관명: "" + html[i+4] + "" 평일 영업시간: "" + html[i+5]), // 인포윈도우에 표춛될 내용
                    iwPosition = new kakao.maps.LatLng(html[i], html[i+1]); // 인포윈도우 표시 위치

                // 인포윈도우를 생성합니다
                var infowindow = new kakao.maps.InfoWindow({
                    position: iwPosition,
                    content: iwContent
          ");
                WriteLiteral(@"          });
                markers.push(marker);            
                // 이벤트 리스너로는 클로저를 만들어 등록합니다 
                kakao.maps.event.addListener(marker, 'mouseover', makeOverListener(map, marker, infowindow));
                kakao.maps.event.addListener(marker, 'mouseout', makeOutListener(infowindow));
                }
            };

            // 클러스터러에 마커들을 추가합니다
            clusterer.addMarkers(markers);

            // 인포윈도우를 표시하는 클로저를 만드는 함수입니다 
            function makeOverListener(map, marker, infowindow) {
                return function () {
                    infowindow.open(map, marker);
                };
            }

            // 인포윈도우를 닫는 클로저를 만드는 함수입니다 
            function makeOutListener(infowindow) {
                return function () {
                    infowindow.close();
                };
            }
        </script>
        <div>
            <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Cor");
                WriteLiteral("e</a>.</p>\r\n        </div>\r\n    ");
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
            WriteLiteral("\r\n</html>");
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
