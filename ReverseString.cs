public string ReverseString(string str)
{
  int start =0;
  int end = str.Length-1;
  char tmp = '';
  while (start < end)
  {
    //swap character at end and start positions
    tmp = str[start];
    str[start] = str[end];
    str[end] = tmp;
    start++;
    end--;
  }
}
