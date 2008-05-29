<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mp4.aspx.cs" Inherits="tv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Lecteurs MP4</title>
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
    <link rel="stylesheet" media="screen" type="text/css" title="ZeBIZshop" href="lib/css/com.css" />
	<script type="text/javascript" src="lib/js/prototype.js" ></script> 
	<script type="text/javascript" src="lib/js/scriptaculous.js" ></script> 
	<script type="text/javascript" src="lib/js/prototype.js" ></script>
	<script type="text/javascript" src="lib/js/com.js" ></script>
</head>
    <body> 
       <!-- L'en-tête -->
 
       <div id="en_tete">
        <div id="logo"></div>
        <div id="connection"> </div> 
       </div>
 
       <!-- Les menus -->
 
       <div id="menu">        
           <div class="element_menu">
               <h3 onclick='slide_menu("menu_image");'>IMAGE</h3>
               <ul  id="menu_image" style="display:none">
                   <li><a href="tv.aspx">TVs</a></li>
                   <li><a href="video.aspx">Videoprojecteurs</a></li>
               </ul>
           </div>               
           <div class="element_menu">
               <h3 onclick='slide_menu("menu_son");'>SON</h3>
               <ul id="menu_son"  >
                   <li><a href="mp3.aspx">Lecteurs MP3</a></li>
                   <li><a href="mp4.aspx">Lecteurs MP4</a></li>
                   <li><a href="ecouteurs.aspx">Ecouteurs</a></li>
               </ul>
           </div>       
           <div class="element_menu">
               <h3 onclick='slide_menu("menu_info");' >INFORMATIQUE</h3>
               <ul id="menu_info" style="display:none">
                   <li><a href="port.aspx">Portables</a></li>
                   <li><a href="mac.aspx">Mac</a></li>
                   <li><a href="logiciels.aspx">Logiciels</a></li>
               </ul>
           </div>   
           <div class="element_menu">
               <h3 onclick='slide_menu("menu_num");'>NUMERIQUE</h3>
               <ul id="menu_num" style="display:none">
                   <li><a href="apn.aspx">Appareils photo</a></li>
                   <li><a href="camescopes.aspx">Camescope</a></li>
               </ul>
           </div>  
           <div class="element_menu">
               <h3 onclick='slide_menu("menu_game");'>JEUX VIDEOS</h3>
               <ul id="menu_game" style="display:none">
                   <li><a href="consoles.aspx">Consoles</a></li>
                   <li><a href="jeux.aspx">Jeux</a></li>
                   <li><a href="accessoires.aspx">Accessoires</a></li>
               </ul>
           </div>  		   
       </div>
 
        <!-- Le pannier -->
       
       <div id="panier">
        <h3>MON PANIER</h3>
       </div>  
       
       <!-- Le corps -->
 
       <div id="corps" >
        <div id="intro">
           <h1>Lecteurs MP4</h1>
           <h2>Vous pouvez triez par <a href="" ><strong>prix</strong></a>  par <a href="" ><strong>type</strong></a> ou par <a href="" ><strong>marque</strong></a></h2> 
        </div>
 
       </div>
       

       
       <!-- Le pied de page -->
 
       <div id="pied_de_page">
       <div class="footrech">        
            Recherche :
            <input type="text" value="Recherche rapide" onclick="this.value=''" id="requete" name="recherche" size="15" maxlength="100" class="requete"/>
            <input type="submit" class="b_ok" value=""/>
        </div>
           <p>Copyright "ZeBIZshop" 2008  -  Tous droits réservés</p>
       </div>
 
   </body>
</html>
