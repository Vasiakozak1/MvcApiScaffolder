using EnvDTE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Shell;
namespace MvcApiScaffolder.Utils
{
    internal class ProjectBuilder
    {
        private DTE _dte;

        public ProjectBuilder()
        {
            _dte = Package.GetGlobalService(typeof(DTE)) as DTE;
        }

        internal void BuildProject(Project project)
        {
            var solutionConfiguration = _dte.Solution.SolutionBuild.ActiveConfiguration.Name;

            _dte.Solution.SolutionBuild.BuildProject(solutionConfiguration, project.FullName, true);
        }
        internal void DetachProject(Project project)
        {

        }
    }
}
