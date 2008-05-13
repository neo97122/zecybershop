<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />
	<link rel="stylesheet" href="css/sample.css" type="text/css" title="default" /> 
	<link rel="alternate stylesheet" href="sea/sea.css" type="text/css" title="sea" />
	<link rel="alternate stylesheet" href="red/red.css" type="text/css" title="rouge" />
	<title>ZeCyberShop - Projet .NET :: Page d'accueil</title>
	<script type="text/javascript" src="script/styleswitcher.js"></script>		
</head>
<body>
<div id="container">
	<div id="intro">
		<div id="pageHeader">
			<h1><span>Site de Commerce Electronique</span></h1>
			<h2><span>Accueil</span></h2>
		</div>

		<div id="quickSummary">
			<p class="p1">
			<span>
			    <asp:Label ID="lblLogged" runat="server" Text="Label">Une petite partie simpose... non ?</asp:Label>
		    </span>
		    </p>
			<p class="p2"><span>Créé par les CyberSellers</span></p>
		</div>

		<div id="preamble">
            &nbsp;<h3><span>Bienvenue</span></h3>
			<p class="p1"><span>
                Bienvenue sur le site créé par les Dameurs, à&nbsp; l'occasion du projet à&nbsp;
                réaliser en .NET ! Amusez vous bien...</span></p>
			<p class="p2"><span>Vous pouvez jouer bien naviguer gratuitement, sans inscription préalable. Toutefois si vous voulez vous enregistrer vos achats , il est impératif de <asp:HyperLink ID="linkInscription" NavigateUrl="inscription.aspx" ToolTip="AccessKey: i" accesskey="i" runat="server">s'inscrire ici</asp:HyperLink> .</span></p>
            
			<p class="p3"><span>Une fois inscrit vous aurez accès au site entier, vous pourrez ainsi profiter de ses avantages.</span></p>
		</div>
	</div>

	<div id="supportingText">
		<div id="explanation">
			<h3><span>Categorie 1</span></h3>
			<p class="p1"><span>Encore un peu de blablah...</span></p>
			<p class="p2"><span>Avec des aperçus des meilleures ventes.<img src="img/damier3.jpg" alt="damier" title="apercu 1 !" width="50%" /></span></p>
		</div>

		<div id="participation">
			<h3><span>Meilleurs VENTES</span></h3>
			<p class="p1"><span>Encore un peu de blablah...</span></p>
			<p class="p2"><span>Avec des aperçus des articles.<img src="img/damier1.jpg" alt="damier" title="apercu 2 !" width="50%" /></span></p>
		</div>

		<div id="benefits">
			<h3><span>Explication des menus</span></h3>
			<p class="p1"><span>menu inscription</span></p>
			<p class="p2"><span>menu navigation</span></p>
			<p class="p2"><span>menu catégories</span></p>
		</div>

		<div id="requirements">
			<h3><span>Requirements</span></h3>
			<p class="p1"><span>Un petit mot sur le groupe, compo...</span></p>
		</div>

	</div>	
	
	<div id="linkList">
		<div id="linkList2">
			<div id="lselect">				
				<h3 class="resources"><span>Resources:</span></h3>
				<ul>
					<li><asp:HyperLink ID="linkaccueil" NavigateUrl="index.aspx" ToolTip="AccessKey: a" accesskey="a" runat="server">Accueil</asp:HyperLink> &nbsp;</li>
					<li><asp:HyperLink ID="linkinscrire" NavigateUrl="inscription.aspx" ToolTip="AccessKey: i" accesskey="i" runat="server">S'inscrire</asp:HyperLink>&nbsp;</li>
					<li><asp:Label ID="lblLog" runat="server" Text="Label"></asp:Label>
					<!--<li><asp:HyperLink ID="linklogin" NavigateUrl="login.aspx" ToolTip="AccessKey: l" accesskey="l" runat="server">Connexion</asp:HyperLink>&nbsp;</li>-->
					</li>
					<li><asp:HyperLink ID="linkgame" NavigateUrl="game.aspx" ToolTip="AccessKey: j" accesskey="j" runat="server">Jouer !</asp:HyperLink></li>
					<li><asp:HyperLink ID="linkhof" NavigateUrl="hof.aspx" ToolTip="AccessKey: c" accesskey="c" runat="server">Classement</asp:HyperLink></li>
					<li><a href="rules.html" title="AccessKey: r" accesskey="r">Rappel des règles</a> &nbsp;</li>
				</ul>
			</div>	
			<div id="lresources">
				<h3 class="select"><span>Choisi ton Style:</span></h3>
				<ul>
					<li><a href="#" onclick="setActiveStyleSheet('default'); return false;">Style par défaut</a></li>
					<li><a href="#" onclick="setActiveStyleSheet('sea'); return false;">Sea</a></li>
					<li><a href="#" onclick="setActiveStyleSheet('rouge'); return false;">Rouge</a></li>
					<li><a href="#" onclick="setActiveStyleSheet('sans style'); return false;">Sans Style</a>&nbsp;</li>
				</ul>
			</div>			
		</div>
	</div>


</div>

</body>
</html>
