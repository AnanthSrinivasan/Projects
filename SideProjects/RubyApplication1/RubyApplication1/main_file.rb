require 'C:\Users\amanoharan\Documents\Visual Studio 2010\Projects\RubyApplication1\RubyApplication1\InterGalaxy.rb'
require 'C:\RailsInstaller\Ruby1.9.3\lib\ruby\gems\1.9.1\gems\roman-numerals-0.3.0\lib\roman-numerals.rb'

#computes the credits for given input and display them.
def compute_credits input
	
#get the roman equivalents of the input string except for the metals
	val = get_roman_equiv(input) 
	
#check for valid roman numeral before getting the decimal equivalent
	validate_roman(val)
	
#If there is metal in the input compute the single piece value
#Multiply the decimal equivalents of roman numbers with single piece value
	total_credits = 0
	if ["Silver","Gold","Iron"].include? input.split(" ").last
			metal = input.split(" ").last
			if(get_metal_value(metal) != nil)	
				single_piece = get_metal_value(metal)	
			end
			total_credits = RomanNumerals.to_decimal(val).to_f * single_piece.to_f
	else
			total_credits = RomanNumerals.to_decimal(val).to_f
	end
	
#Display the Total Credits
	puts "#{input} is #{total_credits} credits"
end