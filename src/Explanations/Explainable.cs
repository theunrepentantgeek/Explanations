using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explanations
{
    public class Explainable<T>
    {
        /// <summary>
        /// Gets the value associated with this explanation
        /// </summary>
        public T Value { get; private set; }

        /// <summary>
        /// Gets the messages that form the explanation for this value
        /// </summary>
        public IEnumerable<ExplanationDetail> Messages { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Explainable class
        /// </summary>
        /// <param name="value"></param>
        public Explainable(T value)
        {
            Value = value;

            var context = Explanation.Current;
            Messages = context == null ? new List<ExplanationDetail>() : new List<ExplanationDetail>(context.Details);
        }
    }
}
