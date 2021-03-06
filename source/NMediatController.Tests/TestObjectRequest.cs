namespace NMediatController.Tests
{
    using System.ComponentModel.DataAnnotations;
    using MediatR;

    public class TestObjectRequest : IRequest<TestResponse>
    {
        [Required]
        public string TestField { get; set; }

        public static TestObjectRequest Valid()
        {
            return new TestObjectRequest { TestField = "valid" };
        }

        public static TestObjectRequest InValid()
        {
            return new TestObjectRequest { TestField = null };
        }
    }
}
