#def romanize num
#	roman = '' #easy way of saying string
#	roman = roman + 'M' * (num       / 1000)
#	roman = roman + 'D' * (num % 1000/  500)
#	roman = roman + 'C' * (num %  500/  100)
#	roman = roman + 'L' * (num %  100/   50)
#	roman = roman + 'X' * (num %   50/   10)
#	roman = roman + 'V' * (num %   10/    5)
#	roman = roman + 'I' * (num %    5/    1)
#	roman
#end
#
#puts romanize(1903)

require 'C:\RailsInstaller\Ruby1.9.3\lib\ruby\gems\1.9.1\gems\roman-numerals-0.3.0\lib\roman-numerals.rb'

#'MCMXLIV'

#roman = gets.chomp 
#puts "Arabic Equivalent is : #{RomanNumerals.to_decimal(roman)}"

str_test = "This is a string"

puts str_test.split(' ').reverse.join(' ')