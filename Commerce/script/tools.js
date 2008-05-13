function addDroppable(element, authorizedElements)
{
    Droppables.add(element.id, {
        accept: 'pion', containment: authorizedElements,
        hoverclass: 'active',        
        onDrop: function(dgPion, dpCase) {
            var caseDorigine = dgPion.parentNode;
            
            // On place le pion dans la nouvelle case et on le retire de l'ancienne
            dpCase.appendChild(dgPion);
            dgPion.style.top = 0;
            dgPion.style.left = 0;
            
            // On désactive la possibilité de mettre un pion dans la case nouvellement occupée...
            Droppables.remove(dpCase);
            
            // ...et on remet la possibilité de glisser 1 pion sur la case liberée        
            addDroppable(caseDorigine, getAuthorizedElements(caseDorigine));
            
            // On informe la couche serveur du changement
            updateTray(dgPion.id, dpCase.id);
        }
    });
}

function updateTray(idPion, idNewCase)
{
    new Ajax.Updater('Plateau', 'Default.aspx', {
        method: 'get',
        parameters: $H({ pion: idPion, newCase: idNewCase }).toQueryString(),
        onSuccess: function() {
            // On supprime les droppables si l'update est réalisé avec succès...
            for (var index = 0, nodes = document.body.getElementsByClassName('black'), l = nodes.length; index < l ; ++index) {
                var node = nodes[index];
                if (!node.hasChildNodes())
                    Droppables.remove(node);
            }
        },
        onComplete: function() {
            // ...et on réinitialise les draggables et les droppables
            initDraggables();
            initDroppables();
        }
    });

}

function getAuthorizedElements(benchmarkElement)
{
    var idCase = benchmarkElement.id;
    var authorizedElements = [];
    var line = parseInt(idCase[1], 10) + 1;
    var column = parseInt(idCase[3], 10);
    /*console.log(idCase);
    console.log("\t"+ 'L' + line + 'C' + (column-1));
    console.log("\t"+ 'L' + line + 'C' + (column+1));*/
    authorizedElements.push('L' + line + 'C' + (column-1), 'L' + line + 'C' + (column+1));
    
    return authorizedElements;
}

function initDraggables()
{
    for (var index = 0, nodes = document.body.getElementsByTagName('img'), l = nodes.length; index < l ; ++index) {
        var node = nodes[index];
        new Draggable(node.id, {
            revert: true, ghosting: true
        });
    }
}
	    
function initDroppables()
{
    for (var index = 0, nodes = document.body.getElementsByClassName('black'), l = nodes.length; index < l ; ++index) {
        var node = nodes[index];
        if (!node.hasChildNodes())
            addDroppable(node, getAuthorizedElements(node));
	}
}

function initGame()
{
    initDraggables();
    /*Draggables.addObserver({
        onStart: function(eventName, draggable) {
            alert(eventName + " - " + draggable.id);
        }
    });*/
    initDroppables();
}

Event.observe(window, 'load', initGame);