using HotChocolate.Types;
using HotChocolate.Types.Descriptors;
using System.Reflection;

namespace ConferencePlanner.GraphQL.Extensions
{
    public class UseUpperCaseAttribute : ObjectFieldDescriptorAttribute
    {
        protected override void OnConfigure(
            IDescriptorContext context,
            IObjectFieldDescriptor descriptor,
            MemberInfo member)
        {
            descriptor.UseUpperCase();
        }
    }
}
