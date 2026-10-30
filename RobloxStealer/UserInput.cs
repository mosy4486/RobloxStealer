using System;
using System.Collections.Generic;
using System.Text;

namespace RobloxStealer
{
    public class UserInput
    {
        public async Task<InputType> GetUserInputAsync(CancellationToken token)
        {
            InputType result = InputType.None;

            while (!token.IsCancellationRequested)
            { 
                string? r = await Console.In.ReadLineAsync();

                if (!Enum.IsDefined(typeof(InputType), r))
                {
                    Console.WriteLine("Not valid value");
                    continue;
                }

                result = (InputType)Enum.Parse(typeof(InputType), r,true);
                break;
            }

            return result;

        }
    }

    
}
