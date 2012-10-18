using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Explanations
{
    public class Explanation : IDisposable
    {
        /// <summary>
        /// Gets the current active Explanation
        /// </summary>
        public static Explanation Current
        {
            get
            {
                var stack = mActiveExplanations.Value;
                if (stack != null && stack.Count > 0)
                {
                    return stack.Peek();
                }

                return null;
            }
        }

        public IEnumerable<ExplanationDetail> Details
        {
            get { return mDetails; }
        }

        /// <summary>
        /// Initializes a new instance of the Explanation class
        /// </summary>
        public Explanation()
        {
            mActiveExplanations.Value.Push(this);
        }

        ~Explanation()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        internal void Explain(ExplanationType kind, string template, params object[] parameters)
        {
            var message = string.Format(CultureInfo.InvariantCulture, template, parameters);
            mDetails.Add(new ExplanationDetail(kind, message));
        }

        private void Dispose(bool includeManaged)
        {
            if (includeManaged)
            {
                var explanation = mActiveExplanations.Value.Pop();
                Debug.Assert(explanation == this);
            }
        }

        /// <summary>
        /// Stack of all currently active Explanations
        /// </summary>
        private static ThreadLocal<Stack<Explanation>> mActiveExplanations
            = new ThreadLocal<Stack<Explanation>>(() => new Stack<Explanation>());

        /// <summary>
        /// List of all our messages to this point
        /// </summary>
        private readonly List<ExplanationDetail> mDetails = new List<ExplanationDetail>();
    }
}
