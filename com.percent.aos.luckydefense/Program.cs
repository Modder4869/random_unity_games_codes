using System;
using System.Security.Cryptography;
using System.Text;
static byte[] ComputeSHA256(string input)
{
    using (SHA256 sha256 = SHA256.Create())
    {
        return sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
    }
}
var pass = "prod-luckydefense.20250319075412.PER_B_A_SE_en#cry$$t@@";
var salt = ComputeSHA256(pass);
var rfc = new Rfc2898DeriveBytes(Encoding.UTF8.GetBytes(pass), salt, 4096);
var key = rfc.GetBytes(32);
Console.WriteLine(BitConverter.ToString(key).Replace("-", ""));
/* 
https://gchq.github.io/CyberChef/#recipe=AES_Decrypt(%7B'option':'Hex','string':'58AF577919AF11DA58D9D0B3DD0BDEE8BFCD106094D25FB8B8B8E6714245A74A'%7D,%7B'option':'Hex','string':'0000000000000000000000000000000'%7D,'CBC','Raw','Raw',%7B'option':'Hex','string':''%7D,%7B'option':'Hex','string':''%7D)Tail('Nothing%20(separate%20chars)',-16)&input=X0qBDTppTmHb5f7gGUIICmS3%2BsOI%2B4Llz78E5qTxtDu71ZZMlJC/9Upnrrsxb9XtlZ3CwPofOal/Pm7y3sgPp0vfc3x50bWTpNXhRfOZ2itw5GdvqWGT%2BYDzuZGVZkygew46/RKYmOv9oGxBKfVOONkobkw6JOhO4ePl5fd6w/AveKBoCgBVv9j7xXs/x%2BlT9dyVg3XSBZPsSP8zpg0L5qjNKJagOhbbASxUOYIu3bE 
*/