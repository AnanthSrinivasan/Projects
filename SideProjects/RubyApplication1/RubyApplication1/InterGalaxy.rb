require 'C:\RailsInstaller\Ruby1.9.3\lib\ruby\gems\1.9.1\gems\roman-numerals-0.3.0\lib\roman-numerals.rb'

#Read the input & Split it into two hash 
#One contains the code and other the metal from which we can decode value for single metal
def read_input
	codehash = {}
	credithash = {}
	File.open('InputFile.txt') do |fp|
		fp.each do |line|
			result = line.scan(/([\S*\s*]*)(Silver|Gold|Iron|glob|prok|pish|tegj)\s*is\s*(\d+|\S)/)
			key, value = line.chomp.split(" is ")
			
			if ["Silver","Gold","Iron"].include? result[0][1]
				credithash[key] = value
			else
				codehash[key] = value
			end
	   end
	end
	return credithash, codehash
end

#get the roman equivalents of the input string except for the metals
def get_roman_equiv input
	val = ""
	credithash, codehash = read_input 
	input.split(" ").each { |r| 
		if codehash.has_key?(r)
			val = val + codehash[r]
		end
	}
	return val
end

#Validates the string against roman numeral restrictions
def validate_roman roman_str
	if roman_str.scan(/^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$/).empty?
		abort("Invalid Roman Language")
	end
end

#Decode the credit hash to know the values for metals
def decode_metal_value
	romanhash = {}
	credithash, codehash = read_input
	credithash.each_pair { |k,v|
		roman_str = get_roman_equiv(k)
		validate_roman(roman_str)
		romanhash[ roman_str + " " + k.split(" ").last ] = v
		}
	return romanhash
end

#Computes the metal value by dividing credits by piece
def metal_values value, metal, credits
	metal = (credits.to_f/value.to_f).to_f
	return metal
end

#Returns the single piece value of metals
def get_single_value
	silver = 0
	gold = 0
	iron = 0
	rhash = decode_metal_value
	rhash.each_pair { |k,v|
		roman = k.split(" ")
		credits = v.split(" ")
		#puts "#{RomanNumerals.to_decimal(roman[0])} * #{roman[1]} = #{v}"
		if (roman[1] == "Silver")
			silver = metal_values(RomanNumerals.to_decimal(roman[0]), roman[1], credits[0])
		elsif (roman[1] == "Gold")
			gold = metal_values(RomanNumerals.to_decimal(roman[0]), roman[1], credits[0])
		elsif (roman[1] == "Iron")
			iron = metal_values(RomanNumerals.to_decimal(roman[0]), roman[1], credits[0])
		else
			puts 'invalid metal'
		end
		}
	return silver, gold, iron	
end

#Returns the metal value	
def get_metal_value(metal)	
	s, g, i = get_single_value 
	if (metal == "Silver")
		return s
	elsif (metal == "Gold")
		return g
	elsif (metal == "Iron")
		return i
	else
		retun nil
	end
end

