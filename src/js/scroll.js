let Scroll = false;

$(document).ready(function(){
  $(window).bind('scroll', function() {
    var currentTop = $(window).scrollTop();
    var elems = $('.team');
    elems.each(function(index){
      var elemTop 	= 899;
      var elemBottom 	= elemTop + $(this).height();
      if(currentTop >= elemTop && currentTop <= elemBottom){
        var id = $(this).attr('id');
        var navElem = $('a[href="/#' + id+ '"]');
        console.log(navElem);
        $('.link').removeClass( 'active' );
        $('#scroll').addClass('active');
      }else{
        $('.link').removeClass( 'active' );
        $('#about').addClass('active');
      }
    })
  }); 
});

$('#scroll').click((e) => { 
  e.preventDefault();
  $('html, body').animate({
    scrollTop: $('#team').offset().top
  }, 800);
});