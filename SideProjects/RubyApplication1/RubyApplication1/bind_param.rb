require 'C:\RailsInstaller\Ruby1.9.3\lib\ruby\gems\1.9.1\gems\sqlite3-1.3.7-x86-mingw32\lib\sqlite3.rb'

begin
    
    db = SQLite3::Database.new "test_tab.db"
    id = 4
   
    stm = db.prepare "SELECT * FROM Cars WHERE Id = :id"
    rs = stm.execute id
    
    row = rs.next    
    puts row.join "\s"
            
rescue SQLite3::Exception => e 
    
    puts "Exception occured"
    puts e
    
ensure
    stm.close if stm
    db.close if db
end