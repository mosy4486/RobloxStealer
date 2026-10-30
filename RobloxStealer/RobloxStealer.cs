using System;
using System.Collections.Generic;
using System.Text;

namespace RobloxStealer
{
    public class RobloxStealer
    {
        private UserInput? input;
        private bool isRunning = false;
        private CancellationTokenSource? source;
        public async Task StartAsync()
        {
            if (isRunning) return;

            input = new UserInput();
            source =  new CancellationTokenSource();

            isRunning = true;

            Task<InputType> inputTask = null;

            CommandPlayer.CommandList();

            while (!source.IsCancellationRequested)
            {
                try
                {
                    if (inputTask == null)
                    {
                        inputTask = input.GetUserInputAsync(source.Token);
                    }

                    if (inputTask.IsCompletedSuccessfully)
                    {
                        InputType inputType = inputTask.Result;
                        _ = Task.Run(()=>PlayInputAsync(inputType));
                        inputTask = null;
                    }
                }
                catch
                { 
                }
            }

            source = null;
            isRunning = false;
        }
        public void Stop()
        { 
            if(!isRunning) return;
            source!.Cancel();
        }

        private async Task PlayInputAsync(InputType inputType)
        {
            switch (inputType)
            { 
                case InputType.None: break;
                case InputType.CommandList: CommandPlayer.CommandList(); break;
                case InputType.PlayerInfo: CommandPlayer.PlayerInfo(); break;
            }
        }
    }

}
