
#Read the input & Split it into two hash 
#One contains the code and other the metal from which we can decode value for single metal
#def read_input
	File.open('Conference.txt') do |fp|
	   fp.each do |line|
			line.split("\r").each { |ln|
					puts ln.split.last
				}
	   end
	end

