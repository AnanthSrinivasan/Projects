require 'C:\RailsInstaller\Ruby1.9.3\lib\ruby\gems\1.9.1\gems\sqlite3-1.3.7-x86-mingw32\lib\sqlite3.rb'

begin
    
    db = SQLite3::Database.open "test_tab.db"

    db.transaction
    db.execute "DROP TABLE IF EXISTS Friends"
    db.execute "CREATE TABLE Friends(Id INTEGER PRIMARY KEY, Name TEXT)"
    db.execute "INSERT INTO Friends(Name) VALUES ('Tom')"
    db.execute "INSERT INTO Friends(Name) VALUES ('Rebecca')"
    db.execute "INSERT INTO Friends(Name) VALUES ('Jim')"
    db.execute "INSERT INTO Friends(Name) VALUES ('Robert')"
    db.execute "INSERT INTO Friends(Name) VALUES ('Julian')"
    db.execute "INSERT INTO Friends(Name) VALUES ('Michael')"
    db.commit
    
rescue SQLite3::Exception => e 
    
    puts "Exception occured"
    puts e
    db.rollback
    
ensure
    db.close if db
end