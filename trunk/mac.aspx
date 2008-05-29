<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mac.aspx.cs" Inherits="tv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Mac</title>
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
               <ul id="menu_son"  style="display:none">
                   <li><a href="mp3.aspx">Lecteurs MP3</a></li>
                   <li><a href="mp4.aspx">Lecteurs MP4</a></li>
                   <li><a href="ecouteurs.aspx">Ecouteurs</a></li>
               </ul>
           </div>       
           <div class="element_menu">
               <h3 onclick='slide_menu("menu_info");' >INFORMATIQUE</h3>
               <ul id="menu_info" >
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
           <h1>MAC - portables</h1>
           <h2>Vous pouvez triez par <a href="" ><strong>prix</strong></a>  par <a href="" ><strong>type</strong></a> ou par <a href="" ><strong>marque</strong></a></h2> 
        </div>
        <table id="articlelist" cellspacing="0" summary="article list">
            <colgroup><col class="small" /><col class="subject" /><col class="from" /><col class="date" /><col class="size" /><col class="icon" /></colgroup>
            <thead>
                <tr>
                    <td class="small">&nbsp;</td>
                    <td class="marque sortedDESC" id="Headmarque"><a href="./#sort" onclick="return ail.command('sort','subject',this)" title="Trier par">Marque</a></td>
                    <td class="type" id="Headtype"><a href="./#sort" onclick="return ail.command('sort','from',this)" title="Trier par">Type</a></td>
                    <td class="description" id="Headdescription"><a href="./#sort" onclick="return ail.command('sort','size',this)" title="Trier par">Description</a></td>
                    <td class="stock" id="Headstock">Stock</td>
                    <td class="prix" id="Headprix"><a href="./#sort" onclick="return ail.command('sort','size',this)" title="Trier par">prix</td>
                    <td class="acheter" id="Headacheter">...</td>
                </tr>
            </thead>
            <tbody>
                <tr id="row1083" class="article odd">
                    <td class="small"><img src="articles/image/images/small/SAMSUNG-LE26S86BD.jpg" alt="SAMSUNG-LE26S86BD" /></td>
                    <td class="marque"><a href="./?_task=mail&amp;_action=show&amp;_uid=1083&amp;_mbox=INBOX" onclick="return rcube_event.cancel(event)">Re: justificatif d absences</a></td>
                    <td class="type"><a href="mailto:nathalie.giraud@insia.org" onclick="return ail.command('compose','nathalie.giraud@insia.org',this)" class="ContactAddress" title="nathalie.giraud@insia.org">NathalieGiraud</a></td>
                    <td class="description">Aujourd'hui 12:16</td>
                    <td class="stock">En Stock</td>
                    <td class="prix">1999.99</td>
                    <td class="acheter" id="Td1">Acheter</td>
                </tr>
                <tr id="row1082" class="article even">
                    <td class="small"><img src="articles/image/images/small/PHILIPS-47PFL7642.jpg" /></td>
                    <td class="marque"><a href="./?_task=mail&amp;_action=show&amp;_uid=1083&amp;_mbox=INBOX" onclick="return rcube_event.cancel(event)">Re: justificatif d absences</a></td>
                    <td class="type"><a href="mailto:nathalie.giraud@insia.org" onclick="return ail.command('compose','nathalie.giraud@insia.org',this)" class="ContactAddress" title="nathalie.giraud@insia.org">NathalieGiraud</a></td>
                    <td class="description">Aujourd'hui 12:16</td>
                    <td class="stock">En Stock</td>
                    <td class="prix">1999.99</td>
                    <td class="acheter" id="Td2">Acheter</td>
               </tr>
                <tr id="row1077" class="article odd">
                    <td class="small"><img src="skins/default/images/icons/dot.png" alt="" border="0" /></td>
                    <td class="marque"><a href="./?_task=mail&amp;_action=show&amp;_uid=1083&amp;_mbox=INBOX" onclick="return rcube_event.cancel(event)">Re: justificatif d absences</a></td>
                    <td class="type"><a href="mailto:nathalie.giraud@insia.org" onclick="return ail.command('compose','nathalie.giraud@insia.org',this)" class="ContactAddress" title="nathalie.giraud@insia.org">NathalieGiraud</a></td>
                    <td class="description">Aujourd'hui 12:16</td>
                    <td class="stock">En Stock</td>
                    <td class="prix">1999.99</td>
                    <td class="acheter" id="Td3">Acheter</td>
                </tr>
                <tr id="Tr1" class="article even">
                    <td class="small"><img src="skins/default/images/icons/dot.png" alt="" border="0" /></td>
                    <td class="marque"><a href="./?_task=mail&amp;_action=show&amp;_uid=1083&amp;_mbox=INBOX" onclick="return rcube_event.cancel(event)">Re: justificatif d absences</a></td>
                    <td class="type"><a href="mailto:nathalie.giraud@insia.org" onclick="return ail.command('compose','nathalie.giraud@insia.org',this)" class="ContactAddress" title="nathalie.giraud@insia.org">NathalieGiraud</a></td>
                    <td class="description">Aujourd'hui 12:16</td>
                    <td class="stock">En Stock</td>
                    <td class="prix">1999.99</td>
                    <td class="acheter" id="Td4">Acheter</td>
               </tr>
                <tr id="Tr2" class="article odd">
                    <td class="small"><img src="skins/default/images/icons/dot.png" alt="" border="0" /></td>
                    <td class="marque"><a href="./?_task=mail&amp;_action=show&amp;_uid=1083&amp;_mbox=INBOX" onclick="return rcube_event.cancel(event)">Re: justificatif d absences</a></td>
                    <td class="type"><a href="mailto:nathalie.giraud@insia.org" onclick="return ail.command('compose','nathalie.giraud@insia.org',this)" class="ContactAddress" title="nathalie.giraud@insia.org">NathalieGiraud</a></td>
                    <td class="description">Aujourd'hui 12:16</td>
                    <td class="stock">En Stock</td>
                    <td class="prix">1999.99</td>
                    <td class="acheter" id="Td5">Acheter</td>
                </tr>
                <tr id="Tr3" class="article even">
                    <td class="small"><img src="skins/default/images/icons/dot.png" alt="" border="0" /></td>
                    <td class="marque"><a href="./?_task=mail&amp;_action=show&amp;_uid=1083&amp;_mbox=INBOX" onclick="return rcube_event.cancel(event)">Re: justificatif d absences</a></td>
                    <td class="type"><a href="mailto:nathalie.giraud@insia.org" onclick="return ail.command('compose','nathalie.giraud@insia.org',this)" class="ContactAddress" title="nathalie.giraud@insia.org">NathalieGiraud</a></td>
                    <td class="description">Aujourd'hui 12:16</td>
                    <td class="stock">En Stock</td>
                    <td class="prix">1999.99</td>
                    <td class="acheter" id="Td6">Acheter</td>
               </tr>
                <tr id="Tr4" class="article odd">
                    <td class="small"><img src="skins/default/images/icons/dot.png" alt="" border="0" /></td>
                    <td class="marque"><a href="./?_task=mail&amp;_action=show&amp;_uid=1083&amp;_mbox=INBOX" onclick="return rcube_event.cancel(event)">Re: justificatif d absences</a></td>
                    <td class="type"><a href="mailto:nathalie.giraud@insia.org" onclick="return ail.command('compose','nathalie.giraud@insia.org',this)" class="ContactAddress" title="nathalie.giraud@insia.org">NathalieGiraud</a></td>
                    <td class="description">Aujourd'hui 12:16</td>
                    <td class="stock">En Stock</td>
                    <td class="prix">1999.99</td>
                    <td class="acheter" id="Td7">Acheter</td>
                </tr>
            </tbody>
        </table>

     
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
