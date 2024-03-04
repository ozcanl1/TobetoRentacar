using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using System.Threading.Tasks;

namespace Application.Features.Cars.Rules
{
    public class CarBusinessRules : BaseBusinessRules
    {
        private readonly ICarRepository _carRepository;
        private readonly ILocalizationService _localizationService;

        public CarBusinessRules(ICarRepository carRepository, ILocalizationService localizationService)
        {
            _carRepository = carRepository;
            _localizationService = localizationService;
        }

        private async Task ThrowBusinessException(string messageKey)
        {
            string message = await _localizationService.GetLocalizedAsync(messageKey);
            throw new BusinessException(message);
        }

        public async Task CarShouldExistWhenSelected(Car? car)
        {
            if (car == null)
                await ThrowBusinessException("CarNotFound");
        }

        public async Task CarShouldNotBeDeleted(Car car)
        {
            if (car?.IsDeleted == true)
                throw new BusinessException("Araç silinmiş durumda.");
        }
    }
}
