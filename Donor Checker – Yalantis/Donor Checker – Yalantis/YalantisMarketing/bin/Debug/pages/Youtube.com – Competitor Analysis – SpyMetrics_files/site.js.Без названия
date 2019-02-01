$('#websearchform-website').devbridgeAutocomplete({
    serviceUrl: '/autocomplete/multi',
    paramName: 'term',
    triggerSelectOnValidInput: false,
    preventBadQueries: false,
    // groupBy: 'section',
    formatResult: function (suggestion, currentValue) {
        return '<a href="'+suggestion.url+'">'+'<img src="' + suggestion.icon + '">&nbsp;' + suggestion.value + '</a>';
    },
    maxHeight: 400, // Максимальная высота списка подсказок, в пикселях
    deferRequestBy: 300,
    onSelect: function (suggestion) {
        window.location = suggestion.url;
    }
});

$(document).ready(function() {
    $('.app-apple').bind('click', function() {$( '#apps-apple' ).click();});
    $('.app-google').bind('click', function() {$( '#apps-google' ).click();});
    $('[data-toggle="tooltip"]').tooltip();
});

// fix dimensions of chart that was in a hidden element
$(document).on('shown.bs.tab','a[data-toggle="tab"]',function () {
  $('.highcharts-container').parent().each(function() {
    $(this).highcharts().reflow();
  });
});

$('#webcompareform-comparewith').devbridgeAutocomplete({
    serviceUrl: '/autocomplete/multi',
    paramName: 'term',
    triggerSelectOnValidInput: false,
    preventBadQueries: false,
    // groupBy: 'section',
    formatResult: function (suggestion, currentValue) {
        return '<a target="_blank" href="'+window.location.pathname + '?compare=' + suggestion.value + '">'+'<img src="' + suggestion.icon + '">&nbsp;' + suggestion.value + '</a>';
    },
    maxHeight: 400, // Максимальная высота списка подсказок, в пикселях
    deferRequestBy: 300,
    onSelect: function (suggestion) {
        window.open(window.location.pathname + '?compare=' + suggestion.value);
    }
});
// Скрипт источника
jQuery.fn.addtocopy = function(usercopytxt) {
    var options = {htmlcopytxt: '<br>More: <a href="'+window.location.href+'">'+window.location.href+'</a> <br>', minlen: 100, addcopyfirst: false};
    jQuery.extend(options, usercopytxt);
    var copy_sp = document.createElement('span');
    copy_sp.id = 'ctrlcopy';
    copy_sp.innerHTML = options.htmlcopytxt;
    return this.each(function(){
        jQuery(this).mousedown(function(){jQuery('#ctrlcopy').remove();});
        jQuery(this).mouseup(function(){
            if(window.getSelection){	//good times
                var slcted=window.getSelection();
                var seltxt=slcted.toString();
                if(!seltxt||seltxt.length<options.minlen) return;
                var nslct = slcted.getRangeAt(0);
                seltxt = nslct.cloneRange();
                seltxt.collapse(options.addcopyfirst);
                seltxt.insertNode(copy_sp);
                if (!options.addcopyfirst) nslct.setEndAfter(copy_sp);
                slcted.removeAllRanges();
                slcted.addRange(nslct);
            } else if(document.selection){	//bad times
                var slcted = document.selection;
                var nslct=slcted.createRange();
                var seltxt=nslct.text;
                if (!seltxt||seltxt.length<options.minlen) return;
                seltxt=nslct.duplicate();
                seltxt.collapse(options.addcopyfirst);
                seltxt.pasteHTML(copy_sp.outerHTML);
                if (!options.addcopyfirst) {nslct.setEndPoint("EndToEnd",seltxt); nslct.select();}
            }
        });
    });
}
$('html').addtocopy({htmlcopytxt: "<br /><a href='" + document.location.href + "'>" + document.location.href + "</a>"});