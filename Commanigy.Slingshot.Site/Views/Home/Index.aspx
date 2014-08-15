<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Slingshot | One-click FTP publishing of files or folders directly from Explorer
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
	<div id="main">
		<div id="main-inner">
			<!-- HOME DISPLAY (start) -->
			<div id="home-display" class="rounded-10">

				<script type="text/javascript">
					$(function () {
						$('#slideshow').cycle({
							fx: 'fade',
							timeout: 5000,
							pager: '#slideshow-nav',
							pagerAnchorBuilder: function (idx, slide) {
								// return sel string for existing anchor
								return '#slideshow-nav li:eq(' + (idx) + ') a';
							},
							speed: 'slow'
						});

						$('#direct').click(function () {
							$('#nav li:eq(2) a').triggerHandler('click');
							return false;
						});

					});
				</script>

				<div id="slideshow-wrapper">
					<ul id="slideshow-nav" class="rounded-5">
						<li><a href="#" class="ie6">
							<!-- -->
						</a></li>
						<li><a href="#" class="ie6">
							<!-- -->
						</a></li>
						<li><a href="#" class="ie6">
							<!-- -->
						</a></li>
					</ul>
					<div id="slideshow">
						<a href="" title="">
							<img src="/Content/images/slide_1.jpg" alt="" />
						</a><a href="" title="Shell integration with Windows Explorer">
							<img src="/Content/images/slide_2.jpg" alt="Shell integration with Windows Explorer" />
						</a><a href="" title="Copy unique URL for uploads">
							<img src="/Content/images/slide_3.jpg" alt="Copy unique URL for uploads" />
						</a>
					</div>
					<!-- #slideshow (end) -->
				</div>
				<!-- #slideshow-wrapper (end) -->
			</div>
			<!-- #home-display (end) -->
			<!-- HOME DISPLAY (end) -->
			<!-- HOME BOXES (start) -->
			<div id="home-box-container">
				<div class="home-box equalize rounded-10">
					<div class="pad">
						<h2>
							What is it?</h2>
						<p>
							A shell-extension for all versions of Windows allowing you to copy a file to a public
							FTP server by right-clicking any file or folder in Explorer and select "Sling to
							Public Site".</p>
						<p>
							Once uploaded you will get an unique URL you may share with your friends.</p>
						<p>
							That's it.</p>
					</div>
					<!-- .pad (end) -->
				</div>
				<!-- .home-box (end) -->
				<div class="home-box equalize rounded-10">
					<div class="pad">
						<h2>
							What does it cost?</h2>
						<p>
							It's free. Enjoy!</p>
					</div>
					<!-- .pad (end) -->
				</div>
				<!-- .home-box (end) -->
				<div class="home-box equalize rounded-10">
					<div class="pad">
						<h2>
							Where do I get it?</h2>
						<p>
							By downloading and running setup.</p>
						<p>
							<b><a href="/slingshot.msi">Download Slingshot v<%= Commanigy.Slingshot.Site.Properties.Settings.Default.Version %></a></b>
						</p>
						<p>
							See <a href="/history.txt">history</a> for changes.
						</p>
					</div>
					<!-- .pad (end) -->
				</div>
				<!-- .home-box (end) -->
				<div class="clear">
				</div>
			</div>
			<!-- #home-box-container (end) -->
			<!-- HOME BOXES (end) -->
		</div>
		<!-- #main-inner (end) -->
	</div>
	<!-- #main (end) -->
</asp:Content>
