# c--part1-exam-prep2

Problem 1 – Zerg!!!
The Prelate Zeratul and the High Templar Tassadar, highly psionic alien life forms from the Protoss race, got together to understand the low-level basic xenomorphic Zerg (in Bulgarian “дзверг“) communication. After years of energy transformation, deep meditation and thousands of Hydralisks cut into pieces, they finally found the answer – the awful creatures send each other encrypted numeric messages (like SMS but without mobile phones).
The messages are made of the following digits: 
0	Rawr
1	Rrrr
2	Hsst
3	Ssst
4	Grrr
5	Rarr
6	Mrrr
7	Psst
8	Uaah
9	Uaha
10	Zzzz
11	Bauu
12	Djav
13	Myau
14	Gruh
Messages are written as a sequence of digits. The last digit of the number (the most right one) has a value as shown in the above table. The next digit on the left has a value 15 times bigger than the shown in the above table, the next digit on the left has 15*15 times bigger value than the shown in the table and so on. Since our Protoss warriors are too advanced to calculate such easy expressions (and on Aiur they do not use C# too), you task is to translate the message into its decimal representation. With your help, our heroes can finally understand the Zerg logic and bring peace to the entire Koprulu sector.
Input
The input data consists of a single line – the Zerg message.
The input data will always be valid and in the described format. There is no need to check it explicitly.
Output
The output data consists of a single line holding the calculated decimal representation of the given message number and should be printed at the console.
Constraints
•	The input number will have between 1 and 9 digits.
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.
Examples
Input	Output	Explanation
Rarr	5	From the table Rarr means 5 in 15th based numeral system. Message is 5. After converting it to decimal – the answer is 5.

Input	Output	Explanation
HsstSsstSsst	498	From the table Hsst means 2, Ssst means 3 and Ssst means 3 in 15th based numeral system. Message is 233. After converting it to decimal – the answer is 498.

Input	Output	Explanation
GruhMyauDjav	3357	From the table Gruh means (E) 14, Myau means (D) 13 and Djav means (C) 12 in 15th based numeral system. Message is EDC. After converting it to decimal – the answer is 3357.


Problem 2 – Moving Letters
Nakov is a keen fan of cryptography. When he was a child, he invented an encryption algorithm called “Moving Letters”. It performs two steps: extracts the letters from the input message and moves each letter a few positions on the right according to its alphabetical order. Your task is to write a program that reads an input message, encrypts it through the “Moving Letters” algorithm and prints the result.
Extracting the Letters
The input message is given as a sequence of words separated by a space. The words are converted into a sequence of letters the following way: until all words disappear, the last letter of each word (if exists) is removed from the word and is appended to the output sequence of letters.
Moving the Letters
The next step in the encryption algorithm is to move each letter (from positions 0, 1, …, n-1) on the right k times. The number k is taken from the number of the letter in the Latin alphabet regardless of its casing ('a'  1, 'b'  2, …, 'z'  26). When a letter is moved to the right, if it is the last letter of the sequence, its next position is the first position in the sequence, just before all the letters.
Example
Let's the input is "Fun exam right". It is first split into 3 words: {"Fun", "exam", "right"}. Then the last letters are extracted: {"Fun", "exam", "right"}  "nmt"  {"Fu", "exa", "righ"}  "nmtuah"  {"F", "ex", "rig"}  "nmtuahFxg"  {"e", "ri"}  "nmtuahFxgei"  {"r"}  "nmtuahFxgeir".
The moving of letters starts from the input sequence "nmtuahFxgeir" and sequentially moves right its first letter (at position 0), then its second letter (at position 1), and so on, and finally moves right its last letter (at position 11). First the letter 'n' at position 0 is moved right 14 times: "nmtuahFxgeir"  "mtnuahFxgeir". Then the letter 't' at position 1 is moved 20 times right: "mtnuahFxgeir"  "mnuahFxgetir". Then the process continues: "mnuahFxgetir"  "mnahFxgetiru"  "mnaFxgetiruh"  "mnaFxgetiruh"  "gmnaFxetiruh"  "gmnaFxtiruhe"  "gmnaiFxtruhe"  "gmrnaiFxtuhe"  "gmrnaiuFxthe"  "gmrnaihuFxte"  "gmrneaihuFxt". The result is "gmrneaihuFxt".
Input
The input data should be read from the console. It consists of a single line holding a sequence of words separated by a single space (followed by the "end of line" character).
Output
The output data consists of a single text line holding the obtained result.
Constraints
•	The input will be less than 256 KB and will hold Latin letters separated by spaces.
•	Allowed working time for your program: 0.35 seconds.
•	Allowed memory: 64 MB.
Sample Input and Output
Input	Output		Input	Output		Input	Output
Fun exam right	gmrneaihuFxt 		Telerik Academy	AymlTiedkaerec		Hi exam	maiHex


Problem 3 – Trails 3D
Trails is a simple reaction game where players race on a grid, leaving colored trails behind them; any player who touches the trails is eliminated, and the last player alive is the winner.
In the example, the two players start at points A and B respectively, moving on the grid and turning left and right, trying to surround each other. In point C, the red player crashes into the blue player's trail and loses the game.
Trails 3D is similar, with the players racing on the surface of a 3D parallelepiped instead of inside a rectangle.
There are two players, starting from the centers of two opposing walls of the cube, and turned in the same direction (towards one another). They move on a grid on the surface, and in every game cycle, they move one position in their current direction; before every move, they can turn left or right (turning is instant and doesn’t count as taking a cycle of game time).  
In the example, the two players start at the centers of the front and back faces; they race on several walls of the cube, until the red player surrounds the blue player, and the blue player crashes in point D. 
Additional rules for movement:
•	two of the walls of the cube are forbidden – а player who tries to move on one of these walls crashes and loses the game; the forbidden walls are opposite one another (on the picture they are marked with diagonal lines);
•	when a player reaches an edge of the cube, he continues moving on the next wall, in the same direction (see point A on the example);
•	a player can move on the edge of the cube (see segment B-C); when he reaches a corner of the cube, he must turn left or right (see point C).
The game ends when one or both of the players crash. If both players crash on the same game cycle, the game is a draw; otherwise, the one who didn't crash wins. Your program will read a sequence of moves from the console, and determine the winner and the distance between the start and endpoint of the red player, along the grid (in this case, 8 – 4 down, and 4 along the bottom edge).
Input
The input data should be read from the console. On the first line, you will read three integers - X, Y and Z - representing the dimensions of the cube. X and Y represent the dimensions of the walls on which the players start, X and Z are the dimensions of the forbidden walls, and Y and Z are the dimensions of the other two walls. The players start in the center of the two opposite X*Y walls, and  move in the direction of edge Y (towards each other; see example input 2 below).
On the second and third line you will read two strings of characters representing the motion of the red and blue players respectively. The motion is represented as a string of 'M', 'L' and 'R' characters, where M means "move without turning, L means "turn left", and R means "turn right". 'M' character may have a number prefix. This number prefix shows how many "move without turning" actions must be performed.
The input data will be correct and there is no need to check it explicitly.
Output
The output data should be printed on the console.
On the first output line you should print “RED”, “BLUE” or “DRAW”, depending on who won the game.
On the second line, print the distance between the start and end points of the red player, measured along the playing grid, as an integer (if the red player crashes into a forbidden wall, his final position is the point where he crashed).
Constraints
•	The numbers X, Y and Z are positive even integers in the range [2…50].
•	The motion strings will be between 2 and 120 characters long (only characters M, L and R).
•	The length of the motion strings will be long enough to finish the game.
•	Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.
Examples
Example input (example on picture)	Example output
8 4 6
2MLM1MRM2MR2MLMLMR3MRM  
LMMR2M4MRMLMRMR1M2MRM	BLUE
9

Example input (players move without turning and crash into each other)	Example output
4 2 4
3M1M
2M1M1M	DRAW
4


Encode and Encrypt
You are currently employed as a Junior MERIN-J (Management of Expression Research, Identification and Normalization – Job). One of your first tasks is to handle electronic messaging in your company, by providing a safe way to transfer messages. Not only should the messages be encrypted (made unreadable for anyone who does not know the cipher) in some way. The CEOs don't want to be wasting extra money on Broadband, so you also have to take care of compressing (encoding) the messages. 
Since you don't have much time (about 6 hours or so), you need to think up of something quickly. Luckily, you have an old article on encryption and encoding, stating the following:
•	We are given a message and a cypher
o	The message is the text the user wants to transmit
o	The cypher is a string which is used to encrypt and decrypt the message
o	The encrypted message is called cypherText
•	We define a function Encrypt, which takes a message and a cypher:
o	It iterates over the symbols in the message and the cypher 
o	For each pair of symbols, it takes their codes (in the table below) and computes the bitwise XOR of the symbol in the message with the symbol in the cypher. 
A	B	C	D	E	F	G	H	I	J	K	L	M	N	O	P	Q	R	S	T	U	V	W	X	Y	Z
0	1	2	3	4	5	6	7	8	9	10	11	12	13	14	15	16	17	18	19	20	21	22	23	24	25
o	The resulting code is summed with the ASCII code of the character 'A' (65), giving a new ASCII code
o	The character corresponding to this new ASCII code is the encrypted representation of the respective character in the message
o	If the cypher string is shorter than the message, using it symbols loops to the beginning of the cypher.  E.g. for a message "ABCDE" and a cypher "PQR" we will have:
	'A' encrypted with 'P' = 'P', 'B' encrypted with 'Q' = 'R', 'C' encrypted with 'R' = 'T', 'D' encrypted with 'P' = 'M', 'E' encrypted with 'Q' = 'U'
o	If the message string is shorter than the cypher, some of its symbols will be encoded several times, until all of the cypher symbols are used.
	E.g. for a message "ABC" and a cypher "PQRST", we will have:
	'A' encrypted with 'P' and the result ('P') encrypted with 'S' = '^' (ASCII 94), 
	'B' encrypted with 'Q' and the result ('R') encrypted with 'T' = 'C',
	'C' encrypted only with 'R' =  'T'
•	We define a function Encode, which takes a string of text to compress:
o	It looks for sequences of symbols which are the same(e.g. 'aaaaa')
o	For each sequence of same symbols, the function replaces the sequence with a number representing the count of repeated symbols, followed immediately by the symbol which is repeated. This is called run-length encoding. E.g. for the text "aaaabbbccccaa" we will have "4a3b4caa".
	The function replaces symbols in the aforementioned way ONLY if the run-length encoding of the same-symbol sequence is shorter than the sequence itself
	That's why in the example above the last two a's remain the same – '2a' has the same length as 'aa'
•	Given the two functions, and given a message and a cypher, the produced result should be:
o	Encode(Encrypt(message, cypher) + cypher) + lengthOfCypher
	+ denotes concatenation, the two functions return strings and 'lengthOfCypher' is a number, which is equal to the number of symbols in the cypher
	i.e. the message is encrypted with the cypher, then the cipher is added for decrypting purposes, then the result is compressed and a number denoting the length of the cypher before compression is added to the compressed string
Write a program, using the method above, which encodes and encrypts a message with a cypher.
Input
The input data should be read from the console.
On the first line of the input, there will be a single string, representing the message.
On the second line of the input, there will be a single string, representing the cypher.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console. Print exactly one line – the cyphered message.
Constraints
•	All symbols in the message will be capital English letters
•	Тhe message and the cypher will be no more than 1500 symbols each
•	Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.
Examples
Input example	Output example
TELERIKACADEMY
SOFTWARE	BKOXHI\EQOGX[YSOFTWARE8
AAABB
BBBBBBA	ABBAA6BA7
JOHNY
DEPPP	KKICXDE3P5


Problem 1 – Multiverse Communication
One day, after eating too much pizza, the master-programmers Niki, Toni and Ivo started talking about “highly-intelligent” topics – how the universe started, who created it, are there other advanced forms of life, what kind of girls are hot and so on. Suddenly they received an answer from beyond to one of the biggest mysteries for the mankind – there is more than one universe in the space-time continuum! As a matter of fact – they are infinite – a multiverse to rule them all! How cool is that, huh?
So, back to our story – somewhere in between the wormholes, dark matter and a lot of space-flying Zerg  Mutalisks, there was another universe almost identical to ours. The very same day after eating too much spaghetti, Ikin, Inot and Ovi (being well trained Terran Ghosts), decided to send telepathically an encrypted numerical message to our well-known software engineers.
The sent message is made of the following digits:
0	CHU
1	TEL
2	OFT
3	IVA
4	EMY
5	VNB
6	POQ
7	ERI
8	CAD
9	K-A
10	IIA
11	YLO
12	PLA
The message is written as a sequence of digits. The last digit of the number (the most right one) has a value as shown in the above table. The next digit on the left has a value 13 times bigger than the shown in the above table, the next digit on the left has 13*13 times bigger value than the shown in the table and so on. Since our masters are too lazy after so much pizza and do not want to think (and code C# too), you task is to translate the message into its decimal representation. With your help, our heroes can fall asleep calmly, knowing other universes exist somewhere.
Input
The input data consists of a single line – the message from the parallel universe.
The input data will always be valid and in the described format. There is no need to check it explicitly.
Output
The output data consists of a single line holding the calculated decimal representation of the given message number and should be printed at the console.
Constraints
•	The input number will have between 1 and 9 digits.
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.
Examples
Input	Output	Explanation
OFT	2	From the table OFT means 2 in 13th based numeral system. Message is 2. After converting it to decimal – the answer is 2.

Input	Output	Explanation
IVAYLO	50	From the table IVA means 3 and YLO means B (11) in 13th based numeral system. Message is 3B. After converting it to decimal – the answer is 50.

Input	Output	Explanation
TELERIK-ACADEMY	45569	From the table TEL means 1, ERI means 7, K-A means 9, CAD means 8 and EMY means 4 in 13th based numeral system. Message is 17984. After converting it to decimal – the answer is 45569.


Problem 2 – Magic Words
We are given a sequence of n magic words. The words are magic because they are capable to perform two “magic” operations: “reorder” and “print”.
Reorder: The reordering operation over n words is performed by sequentially moving the words at positions 0, 1, …, n-1 to positions corresponding to their lengths. More precisely, first the word w0 from position 0 is moved to position len(w0) % (n+1), then the word w1 from position 1 is moved to position len(w1) % (n+1), and so on. Finally the word wn-1 from position n-1 is moved to position len(wn-1) % (n+1). Note that positions are numbered from 0 to n and position 0 is just before the leftmost word and position n is just after the rightmost word.
For example, if we have n = 3 words {"hi", "academy", "exam"}, they will be reordered 3 times this way:
Position	0	1	2	0  2	Position	0	1	2	1  2
Word	hi	academy	exam		Word	academy	hi	exam	

Position	0	1	2	2  0	Position	0	1	2	
Word	academy	hi	exam		Word	exam	academy	hi	
Print: The printing process is simple. It just first prints the first letter of all words, then the second letter of all words (when it exists), then the third letter of all words (when exists), etc. As a result the printing obtains a sequence of letters from the input words.
Your task is to write a program that reads n words, performs the magic operations “reorder” and “print” over them and outputs the obtained sequence of letters.
Input: The input data should be read from the console. The first line holds a single integer number n. At each of the next n lines there is a single word.
Output: The output data consists of a single text line holding the obtained result.
Constraints
•	The number of words n will be in the range [1...1000].
•	Each word will have between 0 and 1000 English letters, each in the range [a…z].
•	Allowed working time for your program: 0.06 seconds.
•	Allowed memory: 32 MB.
Examples
Input	Output		Input	Output		Input	Output		Input	Output
3
hi
academy
exam	eahxciaamdemy		2
you
win	wyionu		1
hi	hi		4
nakov
wrote
this
problem	wnptrarhokoitobsevlem


Problem 3 – Tron 3D
You are implementing a 3D version of the game Tron. If you are not familiar with the standard 2D version, it's a simple reaction game where players race on a grid, leaving colored trails behind them; any player who touches the trails is eliminated, and the last player alive is the winner.

In the example, the two players start at points A and B respectively, moving on the grid and turning left and right, trying to surround each other. In point C, the red player crashes into the blue player's trail and loses the game.

Tron 3D is similar, with the players racing on the surface of a 3D cube instead of inside a rectangle.

There are two players, starting from the centers of two opposing walls of the cube, and turned in the same direction (towards one another). They move on a grid on the surface, and in every game cycle, they move one position in their current direction; before every move, they can turn left or right (turning is instant and doesn’t count as taking a cycle of game time).  

In the example, the two players start at the centers of the front and back faces; they race on several walls of the cube, until the red player surrounds the blue player, and the blue player crashes in point D. 
Additional rules for movement:
•	two of the walls of the cube are forbidden – а player who tries to move on one of these walls crashes and loses the game; the forbidden walls are opposite one another (on the picture they are marked with diagonal lines);
•	when a player reaches an edge of the cube, he continues moving on the next wall, in the same direction (see point A on the example);
•	a player can move on the edge of the cube (see segment B-C); when he reaches a corner of the cube, he must turn left or right (see point C).

The game ends when one or both of the players crash. If both players crash on the same game cycle, the game is a draw; otherwise, the one who didn't crash wins. Your program will read a sequence of moves from the console, and determine the winner and the distance between the start and endpoint of the red player, along the grid (in this case, 8 – 4 down, and 4 along the bottom edge).
Input
The input data should be read from the console. On the first line, you will read three integers - X, Y and Z - representing the dimensions of the cube. X and Y represent the dimensions of the walls on which the players start, Y and Z are the dimensions of the forbidden walls, and X and Y are the dimensions of the other two walls. The players start in the center of the two opposite X*Y walls, and  move in the direction of edge X (towards each other; see example input 2 below).
On the second and third line you will read two strings of characters representing the motion of the red and blue players respectively. The motion is represented as a string of M, L and R characters, where M means "move without turning, L means "turn left", and R means "turn right".
The input data will be correct and there is no need to check it explicitly.
Output
The output data should be printed on the console.
On the first output line you should print “RED”, “BLUE” or “DRAW”, depending on who won the game.
On the second line, print the distance between the start and end points of the red player, measured along the playing grid, as an integer (if the red player crashes into a forbidden wall, his final position is the point where he crashed).
Constraints
•	The numbers X, Y and Z are positive even integers in the range [2…50].
•	The motion strings will be between 2 and 120 characters long (only characters M, L and R).
•	The length of the motion strings will be long enough to finish the game.
•	Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.
Examples
Example input (example on picture)	Example output
8 4 6
MMLMMMMRMRMMLMMRMMRMLMMRMMRMLMMLMMMLMMM
LMMMMRMRMMMLMMRMMMMLMLMMMMRMLMMRMMMMRMM	RED
8

Example input (players move without turning and crash into each other)	Example output
4 2 4
MMMM
MMMM	DRAW
3


Decode and Decrypt
So, being a KO-NE (Key Observation – Notification Expert), you really don't like the idea, that half the company you work for has started using a new method of messaging. This new method encrypts and encodes (compresses) the messages. Encoding is all well and good – company's saving on Broadband and all that jazz – but it's the encryption part you really have a problem with. After all, your job is "observation" and you really can't be effective at that when you can't even read the damn thing.
Good thing is, being as good as you are, you found the source of the idea for the messaging system – some old article, describing a primitive but effective encoding and encryption algorithm. So much for security by obscurity. Here's the encryption and encoding algorithm description from the article:
•	We are given a message and a cypher
o	The message is the text the user wants to transmit
o	The cypher is a string which is used to encrypt and decrypt the message
o	The encrypted message is called cypherText
•	We define a function Encrypt, which takes a message and a cypher:
o	It iterates over the symbols in the message and the cypher 
o	For each pair of symbols, it takes their codes (in the table below) and computes the bitwise XOR of the symbol in the message with the symbol in the cypher. 
A	B	C	D	E	F	G	H	I	J	K	L	M	N	O	P	Q	R	S	T	U	V	W	X	Y	Z
0	1	2	3	4	5	6	7	8	9	10	11	12	13	14	15	16	17	18	19	20	21	22	23	24	25
o	The resulting code is summed with the ASCII code of the character 'A' (65), giving a new ASCII code
o	The character corresponding to this new ASCII code is the encrypted representation of the respective character in the message
o	If the cypher string is shorter than the message, using it symbols loops to the beginning of the cypher.  E.g. for a message "ABCDE" and a cypher "PQR" we will have:
	'A' encrypted with 'P' = 'P', 'B' encrypted with 'Q' = 'R', 'C' encrypted with 'R' = 'T', 'D' encrypted with 'P' = 'M', 'E' encrypted with 'Q' = 'U'
o	If the message string is shorter than the cypher, some of its symbols will be encoded several times, until all of the cypher symbols are used.
	E.g. for a message "ABC" and a cypher "PQRST", we will have:
	'A' encrypted with 'P' and the result ('P') encrypted with 'S' = '^' (ASCII 94), 
	'B' encrypted with 'Q' and the result ('R') encrypted with 'T' = 'C',
	'C' encrypted only with 'R' =  'T'
•	We define a function Encode, which takes a string of text to compress:
o	It looks for sequences of symbols which are the same(e.g. 'aaaaa')
o	For each sequence of same symbols, the function replaces the sequence with a number representing the count of repeated symbols, followed immediately by the symbol which is repeated. This is called run-length encoding. E.g. for the text "aaaabbbccccaa" we will have "4a3b4caa".
	The function replaces symbols in the aforementioned way ONLY if the run-length encoding of the same-symbol sequence is shorter than the sequence itself
	That's why in the example above the last two a's remain the same – '2a' has the same length as 'aa'
•	Given the two functions, and given a message and a cypher, the encrypted message should be:
o	Encode(Encrypt(message, cypher) + cypher) + lengthOfCypher
	'+' denotes concatenation, the two functions return strings and 'lengthOfCypher' is a number, which is equal to the number of symbols in the cypher
	i.e. the message is encrypted with the cypher, then the cipher is added for decrypting purposes, then the result is compressed and a number denoting the length of the cypher before compression is added to the compressed string
Now, since you are very good, you know that the described Encrypt function actually works both ways – i.e. if something was encrypted with the function and a cypher, calling Encrypt again with the same cypher, but with the encrypted text, you will receive the original text.
•	For example, Encrypt("ABCDE", "PQR") = "PRTMU" and Encrypt("PRTMU", "PQR") = "ABCDE"
o	Where the fist parameter of Encrypt is the message and the second is the cypher
The Encode function is also relatively easy to reverse – just take the numbers and print the symbol after each number the corresponding … number … of times.
Input example	Output example
BKOXHI\EQOGX[YSOFTWARE8	TELERIKACADEMY
ABBAA6BA7	AAABB
KKICXDE3P5	JOHNY
Constraints
•	All symbols in the message will have ASCII codes in the range [65; 127]
•	The original message for any encrypted message will always contain only capital English letters
•	The original message will be no longer than 1500 symbols
•	Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.

Now all you have to do is put the pieces together and you can once again spy on the messaging in the company.
Write a program, which by given an encrypted (with the above described method) message, recovers the original message
Input
The input data should be read from the console.
On the only input line there will be the cyphered message
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console. Print exactly one line – the original message (decrypted and decoded)


Problem 1 – TRES4 Numbers
The largest planet in the known universe is TRES4. It is located in the constellation Hercules. For some strange coincidence the TRES4nians (the creatures that live on TRES4) use some of the letters in the Latin alphabet in their numeral system. What is even more surprising the digits in this numeral system, called TRESNUM4, also contain some operators that we use in programming here on Earth. All digits in TRESNUM4 with their decimal representations are:
LON+	0
VK-	1
*ACAD	2
^MIM	3
ERIK|	4
SEY&	5
EMY>>	6
/TEL	7
<<DON	8
A long time ago, Christopher, an eleven years old kid from Arizona, USA, who was extremely good at physics and astronomy, sent a message with the integer coordinates of the Sun and the Earth to the constellation Hercules. Earlier today the message has been received by the TRES4nians. The problem is they don’t know how to convert numbers from decimal numeral system to numbers in TRESNUM4 numeral system and you, like the wisest TRES4nian, must help them by writing a computer program.
Input
The input data consists of a single line – the integer number sent to the TRES4 planet.
The input data will always be valid and in the described format. There is no need to check it explicitly.
Output
The output data consists of a single line holding the TRESNUM4 number representation of the integer number.
Constraints
•	The input number will be between 0 and 18 000 000 000 000 000 000.
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.



Examples
Input	Output		Input	Output
4	ERIK|		154	VK-<<DONVK-

Input	Output		Input	Output
5451	/TELERIK|*ACADEMY>>		891672	VK-EMY>>LON+<<DONVK-*ACADEMY>>


Problem 2 – Bunny Factory
Bunnies are interesting creatures (and cute as hell). If you put two bunnies in a single bordered space and given some time, they will become four, and then eight, and then sixteen, and then thirty two and so on until the whole planet gets filled with little furry balls. Fortunately the humans have put a secret factory to keep this bunny madness under control. 
The bunny factory has N initial cages filled with bunnies. Each cage has more than 1 bunny (so that they can multiply without a problem). The multiplication process consists of several similar cycles and stop when a certain condition is met. On each i-th cycle of the multiplication factory goes through the following steps:
1.	If there are less than i cages, the factory stops the multiplication process.
2.	The factory gets the first i cages and calculate the sum s of all bunnies in them. 
3.	If there are less than s cages after the i-th one, the factory stops the multiplication process.
4.	The factory gets the next s cages after the i-th one and calculates the sum and product of all bunnies in them. 
5.	These sum and product are concatenated as next cages. All cages that were not included in the calculations are simply appended to next.
6.	The factory gets several empty cages then gets the digits of next and for each digit puts the same amount of bunnies in each cell. If the digit is 1 or 0, the digit is ignored.
7.	Step 1 is repeated for the newly generated cages with bunnies.
Here is an example for better clarification:
•	Consider we have 12 cages with these bunnies: 3 2 5 5 4 8 4 9 5 6 3 4.
•	The factory starts the process with the first cycle, so it takes the first cage as sum s – 3. 
•	The factory takes the next 3 cages (2 5 5) after the first one and calculates their sum – 12 – and product – 50. 
•	The factory concatenates the results and appends all the untouched cages – 12, 50 and 48495634 – resulting in 125048495634. 
•	All digits equal to 1 or 0 are excluded – final result is 2548495634.
•	The factory fills the next cages with bunnies – 2 5 4 8 4 9 5 6 3 4.
•	The factory continues with the second cycle (repeating), so it takes the first two cages and calculates their sum s – 2 + 5 – 7.
•	The factory takes the next 7 cages (4 8 4 9 5 6 3) after second one and calculates their sum – 39 – and product – 103680.
•	The factory concatenates the results and appends all the untouched cages – 39, 103680 and 4 – resulting in 391036804.
•	All digits equal to 1 or 0 are excluded – final result is 393684.
•	The factory fills the next cages with bunnies – 3 9 3 6 8 4. 
•	The factory continues with the third cycle (repeating), so it takes the first three cages and calculates their sum – 15.
•	There are no 15 cages after the third one, so the multiplication process stops.
•	The final cages are filled with these bunnies – 3 9 3 6 8 4.
Input
The input data consists of N + 1 lines – the first N lines will be the N initial cages filled with bunnies and the last line will always be "END" indicating the end of the input.
The input data will always be valid and in the described format. There is no need to check it explicitly.
Output
The output data consists of a single line holding the amount of bunnies in each cage after the multiplication process, separated by a single space character (" ").
Constraints
•	N will be between 1 and 100.
•	Bunnies in every cage will be between 1 and 100.
•	Some of the calculations during the multiplication process will have more than 20 digits.
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.
Examples
Input	Output
3
2
5
5
4
8
4
9
5
6
3
4
END	3 9 3 6 8 4


Problem X – Patterns
You are given a matrix of numbers. By given the pattern below, find the pattern with maximal sum:
The pattern consists of neighbor cells in the matrix. The numbers in the cells must be consecutive, i.e. the following rules must be always valid:
A = B -1, B = C – 1, C = D – 1, D = F – 1, F = E – 1, E = G - 1
The size of the pattern is constant and always has the given form.
Example:
The patterns here are marks with green, blue and yellow colors:
•	The green pattern has a sum of its numbers 35
•	The blue pattern has a sum of its numbers 56
•	The yellow pattern has a sum of its numbers -14
The winning pattern is the blue with maximal sum of 56



Input
On the first line of the console you will find the number N – the number of rows and columns of the matrix
On the next N lines you will find exactly N numbers, separated by a space. This are the numbers of the matrix.
The input data will always be valid and in the described format. There is no need to check it explicitly.
Output
The output data consists of a single line. It should start with either “YES” or “NO”:
•	If at least one pattern is found in the matrix – print “YES {sum}”, where sum is the sum of the numbers in the maximal pattern
•	If no patterns are to be found in the matrix – print “NO {sum}”, where sum is the sum of the numbers, that are on the main diagonal of the matrix
Constraints
•	N will always be greater or equal to 5 and less or equal to 1000
•	The numbers in the matrix will always be between -2147483648 and 2147483647
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.
Examples
Input	Output	Explanation
5
1 2 3 4 5
2 3 4 5 6
3 4 5 6 7
4 5 6 7 8
5 6 7 8 9  	YES 42	The found patterns are:
 ,   and  
The last one has the biggest sum, equal to 3+4+5+6+7+8+9 = 42

Input	Output	Explanation
7
1 2 3 4 5 6 7
7 6 5 4 3 2 1
1 2 3 4 5 6 7
7 6 5 4 3 2 1
1 2 3 4 5 6 7
7 6 5 4 3 2 1
1 2 3 4 5 6 7	NO 28	There are no patterns in this matrix
The sum of the main diagonal is printed:
1+6+3+4+5+2+7 = 28

Input	Output	Explanation
8
2 3 4 5 5 4 100 5
5 4 5 1 2 4 3 -2
1 5 6 7 8 6 1 8
-9999 2 3 8 5 6 7 8
2 1 4 9 10 11 -4 6
-5 -4 -3 3 4 5 6 77777
5 -111 -2 2 1 3 7 4
6 7 -1 0 1 2 8 9	YES 56	This is explained in the example above


Problem 4 - Variable Length Coding
Consider the following simple algorithm for encoding (i.e. compressing) text:
•	Count the occurrences of each symbol in each symbol in the text
o	i.e. the “frequency” of a symbol in the text
•	The most frequent symbol will be encoded with a single bit “1”
•	The second most frequent will be encoded with two bits: “11”
•	i.e. if we order the symbols by their frequency, having the most frequent symbol at position 1 and the least frequent symbol at position N:
o	the 1st symbol has a code of one bit with a value of 1
o	the 2nd symbol has a code of two bits with a value of 1
o	…
o	the ith symbol has a code of i bits with a value of 1
o	…
o	the Nth symbol has a code of N bits with a value of 1
•	Go through the text and encode each symbol according to its code from the above rules
o	Separate encoded symbols by placing a single “0” bit between them
o	E.g. if the symbol “a” has to be encoded with the code “1” and “b” has to be encoded with the code “11”, then the text “ab” will be encoded as “1011”
•	The encoded text is then padded with zeroes to the right, so its total length is divisible by 8 (the size of a byte)
o	E.g. for the previous example, where the entire encoded text was “1011”, it will be padded right with 4 zeroes, giving “10110000”
•	The entire encoded text is split into groups of 8 symbols and each of the groups is turned into a 1-byte unsigned integer value (i.e. “parsed” from binary into a byte-sized integer)
o	For the previous example, where the encoded and padded text was “10110000”, there will be exactly 1 group, so the end result will be a single byte integer: 176
	The leftmost bit is considered the most-significant
•	After all the values for the encoded text, we append the code table
o	The code table is a series of lines, each of which a concatenation of a symbol and a number, representing the length of its code
o	E.g. from the previous example the text “ab” will have the following code table:
	a1
b2
	Note: the code length could be more than 1 digit, e.g. a text with the English alphabet, the last line of the code table will be “z26”
•	A broader example: say we have the text “abaaba”. 
o	The most frequent symbol is “a”, followed by “b”.
o	“a” will have the code “1” and “b” will have the code “11”
o	The encoded text will be “1011010101101”, which has a length of 13
o	The encoded text will be padded right with 3 zeroes, giving “1011010101101000”
o	“1011010101101000” will be divided into two groups of 8 symbols:
	 “10110101” and
	 “01101000”
o	“10110101” will be turned into the integer 181 and “01101000” will be turned into the integer 104
o	The end result is the entire text (which was 6 character values) encoded in two bytes, ordered like so: 181 104
o	Of course, we append the code table (each symbol with its code) after the text itself

Now, that’s all well and good, but what’s the use of encoded text if you can’t decode it? That’s where you come in.
Your task is to write a program, which given an encoded by the above rules text (as series of integers, followed by a series of lines of a code table) decodes the integers and prints the original text.
Input
The input data should be read from the console.
On the first line of the input, there will be a sequence of integers, separated by spaces (representing the encoded text)
On the next line, there will be a single integer number L – the number of lines in the code table	
On each of the next L lines there will be a string. 
•	The first symbol of the string describes which symbol from the text this line of the table represents. 
•	All of the remaining symbols will be digits, representing a number (most significant digit is the second symbol in the string), equal to the length of the code for the symbol in the text
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console. Print exactly one line – the original text (decoded)
Constraints
•	The original text will be no more than 4000 symbols
•	Each symbol in the original text will have an ASCII code from 0 to 255
Examples
Input	Output
251 253 214 255 223 187 254 254 183 175 254 240 
11
 2
S5
a6
e1
l7
m3
o8
p9
s10
t4
x11	Some sample text
Input	Output
173 222 
4
 2
a1
b3
c4	aa bc
Note: both examples have a space (" ") character (in both examples it has a code length of 2) 


Problem 5 – Help Doge
Such bone, many move, very enemies, so Doge. Wow.
Doge is a very popular dog. Not very smart, but so cute and popular. He is very hungry and needs your help. Since he is popular he has many enemies.
Doge and his food (bone) are placed on a grid consisting of NxM cells (N vertical cells, numbered from 0 to N-1 and M horizontal cells, numbered from 0 to M-1). Doge is always placed on location [0; 0] and his food is placed on location [Fx; Fy]
(0 <= Fx <= N-1; 0 <= Fy <= M-1).
Doge has K enemies. Each enemy is placed on the grid. Two enemies may be on the same location. There will not be an enemy on location [0; 0] (where Doge is) and there will not be an enemy on location [Fx; Fy] (where the food is).
Doge is allowed only to move in two directions (right and down) and is not allowed to step on locations where his enemies are.
Count and return the number of all possible ways for the Doge to go from his start location to the food. If there is no way for the Doge to go from his start position to the food, return 0. Wow.
Input
The input data should be read from the console.
On the first line there will be the numbers N and M, separated by a single space.
On the second line there will be the integer numbers Fx and Fy, separated by a single space.
On the third line there will be the number K – the number of Doge`s enemies.
On the next K lines there will be the X and Y coordinates for each Doge`s enemy, separated by a space.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console.
Output the number of all possible ways for the Doge to go from his initial position to the food.
Constraints
•	The numbers N and M will be a non-negative integers between 1 and 500, inclusive.
•	The number K will be a non-negative integer between 0 and 10000.
•	Allowed working time for your program: 0.25 seconds. Allowed memory: 64 MB.
•	Wow.
Examples
Input	Output		Input	Output		Input	Output
4 5
3 4
3
1 1
2 2
2 3	5


// See the
// picture
// above		10 12
8 8
4
1 2
7 3
8 7
3 5	2654
		12 15
1 1
3
2 2
3 3
4 4	2

Wow.


Problem 1 – StrangeLand Numbers
Welcome to StrangeLand town! Absolutely everything is strange here! The location of the town is strange, people are strange, their houses are strange, the language they use is strange, their numeral system is strange and etc. Let’s talk about the StrangeLand numeral system. It consists of 7 digits, each one having a different length and all of them using lowercase and possibly uppercase letters from the Latin alphabet (and no – it’s not the alphabet that people use in StrangeLand, they have a really special one but that’s another story). Here are the StrangeLand digits and their decimal representations:
0	f
1	bIN
2	oBJEC
3	mNTRAVL
4	lPVKNQ
5	pNWE
6	hT
Recently Merry, a very skillful tennis player, found out about StrangeLand. She was very interested in the StrangeLand numeral system and wrote some numbers using it. Now she wants to know what their decimal representations are but she doesn’t know how to convert numbers from StrangeLand numeral system to numbers in decimal numeral system. You must help her by writing a program that converts a StrangeLand number to a decimal number knowing that the last digit of the number (the most right one) has a value as shown in the above table. The next digit on the left has a value 7 times bigger than the shown in the above table, the next digit on the left has 7*7 times bigger value than the shown in the table and so on.
Input
The input data consists of a single line – the StrangeLand number you must convert to a decimal number.
The input data will always be valid and in the described format. There is no need to check it explicitly.
Output
The output data consists of a single line holding the decimal representation of the StrangeLand number.
Constraints
•	The input number will have between 1 and 24 digits.
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.


Examples
Input	Output		Input	Output
lPVKNQ	4		pNWEoBJECbINf	1820

Input	Output		Input	Output
bINoBJECpNWEhT	482		hTmNTRAVLoBJEClPVKNQfffoBJECpNWE	37361980


Problem 2 – Two Girls, One Path
Molly and Dolly are two cute little girls playing in a local park. They decided to compete with each other in an easy game – which one will collect more flowers. Since the girls are too young to calculate the final score, they need your help. And since you are too lazy to count by hand, you have to write a program to make it for you.
The rules for the game follow:
•	The game field is a circular path of N cells. Each cell may have F flowers in it.
•	Each cell is numbered with integer from 1 to N.
•	Molly and Dolly are collection flowers jumping from one cell to another.
•	They start next to each other but moving in opposite directions.
•	Molly starts at cell 1 and moves towards cell N.
•	If Molly reaches cell N and has to move forward, she continues to cell 1 (circular path).
•	Dolly starts at cell N and moves towards cell 1.
•	If Dolly reaches cell 1 and has to move forward, she continues to cell N (circular path).
•	When one of the girls reaches a cell, she collects all the F flowers on that cell.
•	The girl then jumps F cells ahead of the current cell, depending on the moving direction.
•	If one of the girls reaches a cell with no flowers in it, the game ends.
•	If the both girls move at the same time to the same cell full of flowers, they split the flowers evenly and leave the rest into the cell. If the cell contains even amount of flowers, they split them in half and zero flowers are left in the cell. If the cell contains odd amount of flowers, they leave 1 flower in the cell and split the rest in half.
•	If the both girls move at the same time to the same cell full of F flowers, they both jump F cells forward.
•	The girls never change their moving directions.
•	Both girls collect the flowers on their starting cell before moving to the next one.
•	The two girls collect flowers and move at the same time. 
Detailed example:
•	We have a path with 8 cells.
•	Molly starts at cell 1 and collects 4 flowers.
•	Dolly starts at cell 8 and collects 2 flowers.
•	Molly moves 4 cells ahead jumping on cell 5.
•	Dolly moves 2 cells ahead jumping on cell 6.
•	Molly is at cell 5 and collects 7 flowers – 11 in total.
•	Dolly is at cell 6 and collects 11 flowers – 13 in total.
•	Molly moves 7 cells ahead jumping on cell 4.
•	Dolly moves 11 cells ahead jumping on cell 3.
•	Molly is at cell 4 and collects 2 flowers – 13 in total.
•	Dolly is at cell 3 and collects 4 flowers – 17 in total.
•	Molly moves 2 cells ahead jumping on cell 6.
•	Dolly moves 4 cells ahead jumping on cell 7.
•	Molly is at cell 6 but there are no flowers left.
•	Dolly is at cell 7 and collects 3 flowers – 20 in total.
Input
The input data consists of one line – the path cells full of flowers, separated by space character (" ").
The input data will always be valid and in the described format. There is no need to check it explicitly.
Output
The output data consist of two lines.
On the first line write down the girl, who did not reach an empty cell – "Molly", "Dolly" or "Draw", if both of them reach an empty cell at the same time.
On the second line write down first the total amount of flowers Molly collected and then the total amount of flowers Dolly collected, separated by space character (" ").
Constraints
•	N will be between 2 and 1 000 inclusive.
•	F will be between 0 and 9 200 000 000 000 000 000.
•	All paths can be finished with above rules.
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.
Examples
Input	Output
4 17 4 2 7 11 3 2	Dolly
13 20


Problem 3 – Digits
You are given a matrix of digits. The matrix contains some patterns that form digits. Your task is to find these digits and calculate their sum:
The digit patterns are as follows:
Each digit patterns is formed by the same digit:
•	The one-digit pattern is formed from cells with the digit one
•	The nine-digit pattern is formed from cells with the digit nine
•	Etc…
The size of the patterns is constant and always has the given form.

Example:
The digit patterns are marked in green, red and blue
Four digit patterns are found – twice one-digit, one seven-digit and one four-digit pattern.
The sum is 1 + 1 + 4 + 7 = 13





Input
On the first line of the console you will find the number N – the number of rows and columns of the matrix
On the next N lines you will find exactly N digits, separated by a space. These are the digits of the matrix.
The input data will always be valid and in the described format. There is no need to check it explicitly.
Output
The output data consists of a single line. It should contain the sum of all the digit patterns in the matrix
Constraints
•	N will always be greater or equal to 5 and less or equal to 1250
•	The values in the matrix will always be digits
•	Allowed working time for your program: 0.3 seconds.
•	Allowed memory: 32 MB.
Examples
Input	Output	Explanation
5
1 1 1 1 1
1 1 1 1 1
1 1 1 1 1
1 1 1 1 1
1 1 1 1 1	3	The one-patern is found three times.
The sum is 1+1+1 = 3

Input	Output	Explanation
7
9 9 9 2 2 2
9 9 9 2 2 2
9 9 9 2 2 2
9 9 9 2 2 2
9 9 9 2 2 2
9 9 9 2 2 2	22	The nine-pattern is found twice and the two-pattern is also found twice.
The sum is 9 + 9 + 2 + 2 = 22

Input	Output	Explanation
8
3 2 1 1 2 3 0 1
2 1 1 9 7 6 4 0
1 4 1 7 7 7 5 1
2 4 1 4 2 7 1 1
3 4 1 4 7 1 3 1
0 4 4 4 7 4 5 1
5 8 2 4 7 3 2 1
1 2 7 4 9 2 1 8	13	This is explained in the example above


Problem 4 - Relevance Index
Given several paragraphs (lines) of text and a search word, the relevance index of a paragraph is the number of occurrences of that search word (as a separate word) in the paragraph. Here, comparison is case insensitive, i.e. the only thing that is important is the words have the same letters, ignoring casing.
Hence, ordering text by relevance index means creating a new text and
•	Finding the paragraph with the highest relevance index (in the old text) and placing it first
•	Then finding the paragraph with the second-highest relevance index (in the old text) and placing it second 
•	and so on…
You are tasked with ordering paragraphs by relevance index, given a search word. Furthermore, all letters of all occurrences of the search word must be made uppercase in the resulting ordered text and any punctuation should be removed and words should be separated by a single space.
The paragraphs can contain English letters (upper- and lower-case), spaces and punctuation to separate words. Punctuation characters are: ",", ".", "(", ")", ";", "-", "!", "?" (comma, dot, parentheses, semicolon, dash, exclamation mark, question mark).
Input
The input data should be read from the console.
On the first line of the input, there will be a single string – the search word.
On the second line there will be a single integer number L – the number of paragraphs in the text.
On each of the next L lines there will be a single string – the text in the respective paragraph.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console. Print exactly L lines – the paragraphs with removed punctuation, each two words separated by a single space and the words matching the search word converted to uppercase.
Constraints
•	L will be no more than 100
•	Each line will be no longer than 1000 characters
•	Each symbol in the original text will have an ASCII code from 0 to 255
•	Time limit: 0.10 seconds
•	Memory limit: 16 MB
Examples
Input	Output
a
3
a b c
b a a
c a a a	c A A A
b A A
A b c
Input
text
5
if you have someone to text
but the text is more than text to text
and you need a better text to text
try to text what the text would want to text another text with text
cause this text is too much about text, and a text will never teach you how to text
Output
try to TEXT what the TEXT would want to TEXT another TEXT with TEXT
cause this TEXT is too much about TEXT and a TEXT will never teach you how to TEXT
but the TEXT is more than TEXT to TEXT
and you need a better TEXT to TEXT
if you have someone to TEXT


Problem 5 – DogeCoin
Much coin, how money, such currency, so crypto. Wow.
Doge is a very popular dog. He is so popular that there is a crypto currency named after him. The crypto currency is named DogeCoin. Doge loves his DogeCoins and wants to gather as much as he can. Help this cute little animal.
Doge and the DogeCoins are placed on a grid consisting of NxM cells (N vertical cells, numbered from 0 to N-1 and M horizontal cells, numbered from 0 to M-1). Doge is always placed on location [0; 0]. Doge is allowed only to move in two directions (right and down).
There are K coins on the grid. Two or more coins may be on the same location. There also might be a coin(s) where Doge starts (0, 0) and he automatically gathers them.
Find the biggest possible amount of coins that Doge can gather when moving only down and right.
Wow.
Input
The input data should be read from the console.
On the first line there will be the numbers N and M, separated by a single space.
On the second line there will be the number K – the number of the coins on the grid.
On the next K lines there will be the X and Y coordinates for each coin, separated by a space. X means the number of the row counting from 0 and Y means the number of the column, counting from 0 where the coin is located.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console.
Output the biggest possible amount of coins that Doge can gather when moving only down and right.
Constraints
•	The numbers N and M will be non-negative integers between 1 and 2000, inclusive.
•	The number K will be a non-negative integer between 0 and 100000.
•	The coordinates of the coins will always be within the given grid.
•	Allowed working time for your program: 0.2 seconds.
•	Allowed memory: 64 MB.
 
Examples
Input	Output		Input	Output		Input	Output
4 5
7
1 4
0 3
1 2
2 1
3 1
1 2
2 4	4


// See the
// picture
// above		10 10
11
0 0
1 1
2 2
3 3
4 4
5 5
6 6
7 7
8 8
8 9
9 9	11		4 4
11
1 1
2 1
1 2
2 1
3 3
0 3
3 0
3 1
3 3
1 1
1 0	8

Wow.
