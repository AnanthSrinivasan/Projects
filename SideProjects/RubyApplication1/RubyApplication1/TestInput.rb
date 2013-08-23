require 'C:\Users\amanoharan\Documents\Visual Studio 2010\Projects\RubyApplication1\RubyApplication1\main_file.rb'
require 'C:\RailsInstaller\Ruby1.9.3\lib\ruby\gems\1.9.1\gems\ruby-dictionary-1.0.1\lib\ruby-dictionary.rb'

#form the dictionary with valid words
#dictionary = Dictionary.new(%w(Silver Gold Iron glob prok pish tegj))
dictionary = { "Silver" => 1, "Gold" => 2, "Iron" => 3, "glob" => 4, "prok" => 5, "pish" => 6, "tegj" => 7 }

loop do 
	#Get the Transaction Question 
	puts 'Enter the Transaction'
	question = gets.chomp
	question.slice!(/\?/)

	#Removes how many/how much credits and takes up the meat alone
	ques_ary = question.sub(/^.*\sis\s/, "")

	#Ensures that given input only contains the dictionary words
	ques_ary.split(" ").each { |qw|
		unless dictionary.has_key?(qw)
			puts "Unrecognized language"
			break
		end
		}

	#Compute credits and display
	compute_credits(ques_ary)

	puts "Continue? Press N to stop :"
	repeat = gets.strip
	
	break if repeat == 'N'
end 

