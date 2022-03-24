using System;
using System.Collections.Generic;
using System.Text;

namespace Search_with_Extensions.Extension_method
{
    static class Contain
    {

        public static bool customContains(this string sentence,string word)
        {
            bool tf = false;
            int count = 0;
            sentence = sentence.ToLower();
            word = word.ToLower();

            for(int i = 0; i < word.Length; i++)
            {
                char check = word[0];
                if(sentence[i] == check)
                {
                    tf = true;
                }
                else
                {
                    if(sentence[i] == word[0] && sentence[i + 1] == word[1])
                    {
                        tf = true;

                        count = i;

                        for(int j = 2; j < word.Length; j++)
                        {
                            if(sentence[count + 2] == word[j])
                            {
                                count++;
                                tf = true;
                            }
                            else
                            {
                                tf = false;
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }            
            return tf;
        }

    }
}
