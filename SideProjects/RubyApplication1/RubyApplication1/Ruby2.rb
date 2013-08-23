require 'C:\RailsInstaller\Ruby1.9.3\lib\ruby\gems\1.9.1\gems\roman-numerals-0.3.0\lib\roman-numerals.rb'
require 'C:\RailsInstaller\Ruby1.9.3\lib\ruby\gems\1.9.1\gems\ruby-dictionary-1.0.1\lib\ruby-dictionary.rb'
#
#def file_hash 
#	fileContents=[]  # start with an empty array
#	#hash = Hash.new
#	File.open('InputFile.txt') do |fp|
#	  fp.each do |line|
#		#key, value = line.chomp.split(" is ")
#		#hash[key] = value
#		fileContents.push line 
#	  end
#	end
#	return fileContents 
#end
#
##hash = Hash.new 
#hash = file_hash 
#puts hash
##hasheach_pair{|key, value| puts "#{key} = #{value}"}
#
##left, right = hash.partition {|k,v| keyset.include? k }

#def get_arabic roman
#	puts roman
#	return RomanNumerals.to_decimal(roman)
#end

puts 'hello'
#		code_arr.each { |c|
#			puts c
#			roman_val = codehash[c]
#			#puts roman_val
#			}
#		outp = k.scan(/([\S*\s*]*)(S|G|I)/)
##		res = outp[0][0].split(" ")
##		res.each {|r| 
##			puts codehash[r]
#result = question.scan(/(Silver|Gold|Iron|glob|prok|pish|tegj)/)
#		if dictionary.exists?(qw)
#			#puts 'hi'
#		else
#			puts "Couldn't recognize your language"
#		end
#		
#codearr = k.split(" ")

#str = "how much is pish tegj glob glob"
#puts str.sub(/^.*\sis\s/, "")


#			k.split(" ").each { |r|
#				if(get_roman_code(r) != nil)
#					val = val + get_roman_code(r)
#				end
#			}	

#	val = ""
#	input.split(" ").each { |r| 
#		if(get_roman_code(r) != nil)
#			val = val + get_roman_code(r)
#		end
#	}	

#val = "IVIDIV"
#puts RomanNumerals.to_decimal(val)
#q = val.scan(/[D|L|V]/)
#
#h = Hash.new(0)
#q.each { | v | h.store(v, h[v]+1) }
#
#h.each_value { |v|
#	if v.to_i > 1
#		puts "invalid"	
#	end
#	}

#puts val.count('dlv')
#val = "XCVIICX"
#if val.scan(/^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$/).empty?
#	puts 'invalid'
#end
#if result == []
#	puts 'invalid'
#else
#	puts 'valid'
#end
#puts result.inspect
#puts result[0][1]
#puts RomanNumerals.to_decimal(result[1])

#val.scan(/^(M{0,4}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})|[IDCXMLV])$/)
	  
#if val.count('D') > 1 || val.count('L') > 1 || val.count('V') > 1
#	puts 'hi'
#else
#	puts 'input proper'
#end

#roman.scan(/^(M{0,4}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})|[IDCXMLV])$/)
#dictionary = Dictionary.new(%w(Silver Gold Iron glob prok pish tegj))
#dictionary = { "Silver" => 1, "Gold" => 2, "Iron" => 3, "glob" => 4, "prok" => 5, "pish" => 6, "tegj" => 7 }
#
#"prok glob glob glob".split(" ").each { |qw|
#	puts qw
#		unless dictionary.exists?(qw) 
#			puts "Unrecognized language"
#			break
#		end
#		}

#puts "Glob GLOB ".strip

val = "IIII"
puts RomanNumerals.to_decimal(val).to_s


#def coolDude(a, case_sensitive = false)
#	if case_sensitive.is_a?(TrueClass)
#		puts  "#{a} -- #{case_sensitive}."
#	end
#end
#
#a = %w(Abc Def ghi jkl)
#coolDude(a, "hi")
		
#str1="glob"
#puts str1.eql?("Glob")
