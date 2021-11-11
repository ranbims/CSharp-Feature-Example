using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousMembers
{
    // Ref: https://stackoverflow.com/questions/44096253/await-task-completedtask-for-what
    public class CompletedTaskExample
    {
        public class SampleModel
        {
            public string Title { get; set; }
            public string Description { get; set; }
        }

        public async Task<IEnumerable<SampleModel>> GetDataAsync()
        {
            await Task.CompletedTask; // <-- CompletedTaskExample
            var data = new List<SampleModel>();

            data.Add(new SampleModel
            {
                Title = "Lorem ipsum dolor sit 1",
                Description = "Lorem ipsum dolor sit amet"
            });

            data.Add(new SampleModel
            {
                Title = "Lorem ipsum dolor sit 2",
                Description = "Lorem ipsum dolor sit amet"
            });
            return data;
        }

        // An equivalent way
        public async Task<IEnumerable<SampleModel>> GetDataAsyncEqu()
        {
            var data = new List<SampleModel>();

            data.Add(new SampleModel
            {
                Title = "Lorem ipsum dolor sit 1",
                Description = "Lorem ipsum dolor sit amet"
            });

            data.Add(new SampleModel
            {
                Title = "Lorem ipsum dolor sit 2",
                Description = "Lorem ipsum dolor sit amet"
            });
            return await Task.FromResult<IEnumerable<SampleModel>>(data);
        }
    }
}
