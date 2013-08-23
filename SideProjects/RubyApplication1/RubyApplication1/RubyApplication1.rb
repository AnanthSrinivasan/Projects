require 'C:\RailsInstaller\Ruby1.9.3\lib\ruby\gems\1.9.1\gems\sinatra-1.4.3\lib\sinatra.rb'
require 'C:\RailsInstaller\Ruby1.9.3\lib\ruby\gems\1.9.1\gems\slim-2.0.0\lib\slim.rb'

get '/test' do
  slim :index
end

__END__

#@@layout
#doctype html
#html
#  head
#    meta charset="utf-8"
#    title Just Do It
#    link rel="stylesheet" media="screen, projection" href="/styles.css"
#    /[if lt IE 9]
#      script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"
#  
#  <div>
#<script type="text/javascript" src="http://app.ecwid.com/script.js?2212068" charset="utf-8"></script>
#<script type="text/javascript"> xCategories("style="); </script>
#</div>
#
#<div>
#<script type="text/javascript" src="http://app.ecwid.com/script.js?2212068" charset="utf-8"></script>
#<script type="text/javascript"> xProductBrowser("categoriesPerRow=3","views=grid(3,3) list(10) table(20)","categoryView=grid","searchView=list","style="); </script>
#<noscript>Your browser does not support JavaScript. Please proceed to <a href="http://app.ecwid.com/jsp/2212068/catalog">HTML version of Ananth Srinivasan's store</a></noscript>
#</div>
#
#<div>
#<script type="text/javascript" src="http://app.ecwid.com/script.js?2212068" charset="utf-8"></script>
#<!-- remove layout parameter if you want to position minicart yourself -->
#<script type="text/javascript"> xMinicart("style=","layout=attachToCategories"); </script>
#</div>
#
#
#  
#  body
#    h1 Just Do It
#    == yield
#@@index
#h2 My Tasks
#ul.tasks
#  li Get Milk
#
