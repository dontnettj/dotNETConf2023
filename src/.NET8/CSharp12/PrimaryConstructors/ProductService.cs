using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryConstructors
{
    internal class ProductService(IProductRepository productRepository, IEmailService emailService)
    {
        private readonly IProductRepository productRepository = productRepository;
        private readonly IEmailService emailService = emailService;


    }
}
