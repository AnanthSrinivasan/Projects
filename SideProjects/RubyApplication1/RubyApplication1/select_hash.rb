require 'C:\RailsInstaller\Ruby1.9.3\lib\ruby\gems\1.9.1\gems\sqlite3-1.3.7-x86-mingw32\lib\sqlite3.rb'

begin
    
    db = SQLite3::Database.open "test_tab.db"
    db.results_as_hash = true
        
    ary = db.execute2 "SELECT * FROM Cars LIMIT 5"    
    	
    ary.each do |row|
        
		puts "%s | %s | %s" % [row[0], row[1], row[2]]
    end
             
rescue SQLite3::Exception => e 
    
    puts "Exception occured"
    puts e
    
ensure
    db.close if db
end