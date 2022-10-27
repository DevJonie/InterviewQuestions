/*
 Julius Caesar protected his confidential information by encrypting it using a cipher. Caesar's cipher shifts each letter by a number of letters. If the shift takes you past the end of the alphabet, just rotate back to the front of the alphabet. In the case of a rotation by 3, w, x, y and z would map to z, a, b and c.

Original alphabet:      abcdefghijklmnopqrstuvwxyz
Alphabet rotated +3:    defghijklmnopqrstuvwxyzabc
*/


Console.WriteLine(CeasarCipher("abcdefghijklmnopqrstuvwxyz", 3));

static string CeasarCipher(string s, int k = 3)
{
    var encryptedStr = new char[s.Length];

	for (int i = 0; i < s.Length; i++)
	{
		encryptedStr[i] = (char)GetShiftedCharindex(s[i], k);
	}

	return string.Join("", encryptedStr);
}

static int GetShiftedCharindex(char v, int k)
{
	int charIndex = (int)v;
	int ai = (int)'a';
	int zi = (int)'z';
	if (charIndex >= (int)'A' && charIndex <= (int)'Z')
	{
		ai = (int)'A';
		zi = (int)'Z';
	}
	
	if(charIndex < ai || charIndex > zi)
	{
		return charIndex;
	}

	var shiftedIndex = charIndex + (k % 26);

	if (shiftedIndex > zi)
	{
		shiftedIndex = shiftedIndex - zi + ai - 1;
	}

	return shiftedIndex;
}