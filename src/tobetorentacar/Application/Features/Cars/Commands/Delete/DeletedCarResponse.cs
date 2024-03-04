using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.Features.Cars.Commands.Delete
{
    public class DeletedCarResponse
    {
        public Guid CarId { get; set; }

        public DeletedCarResponse(Guid carId)
        {
            CarId = carId;
        }
    }
}
