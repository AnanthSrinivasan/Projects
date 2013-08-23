#!/usr/bin/ruby

require 'C:\RailsInstaller\Ruby1.9.3\lib\ruby\gems\1.9.1\gems\sqlite3-1.3.7-x86-mingw32\lib\sqlite3.rb'

begin
    
    db = SQLite3::Database.open "test_tab.db"
    db.execute "CREATE TABLE IF NOT EXISTS Cars(Id INTEGER, 
        Name TEXT, Price INT)"
    db.execute "INSERT INTO Cars VALUES(1,'Audi',52642)"
    db.execute "INSERT INTO Cars VALUES(2,'Mercedes',57127)"
    db.execute "INSERT INTO Cars VALUES(3,'Skoda',9000)"
    db.execute "INSERT INTO Cars VALUES(4,'Volvo',29000)"
    db.execute "INSERT INTO Cars VALUES(5,'Bentley',350000)"
    db.execute "INSERT INTO Cars VALUES(6,'Citroen',21000)"
    db.execute "INSERT INTO Cars VALUES(7,'Hummer',41400)"
    db.execute "INSERT INTO Cars VALUES(8,'Volkswagen',21600)"
    
rescue SQLite3::Exception => e 
    
    puts "Exception occured"
    puts e
    
ensure
    db.close if db
end