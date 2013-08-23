

require 'C:\RailsInstaller\Ruby1.9.3\lib\ruby\gems\1.9.1\gems\sqlite3-1.3.7-x86-mingw32\lib\sqlite3.rb'

begin
    
    db = SQLite3::Database.open "test.db"
	  
    val = db.get_first_value "SELECT Id FROM Cars WHERE Name='Bentley'"       
    puts val
    
rescue SQLite3::Exception => e 
    
    puts "Exception occured"
    puts e
    
ensure
    db.close if db
end