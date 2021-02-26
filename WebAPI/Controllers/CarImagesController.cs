using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        private ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpPost("addimages")]
        public async Task<IActionResult> Add(List<IFormFile> images, [FromForm] CarImage carImage)
        {
            var guidKey = Guid.NewGuid().ToString();
            guidKey = Path.ChangeExtension(guidKey, "jpg");
            var filePath = @"C:\Users\igmo\source\repos\ReCapProject\WebAPI\Images\CarImages\" + guidKey;

            IResult result = null;

            foreach (var image in images)
            {
                if (image.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await image.CopyToAsync(stream);
                    }

                    carImage.Date = DateTime.Now;
                    carImage.ImagePath = filePath;
                    carImage.Id = 0;
                    result = _carImageService.Add(carImage);
                }
            }

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("updatefile")]
        public async Task<IActionResult> Update(IFormFile image, [FromForm] int imageId)
        {
            var guidKey = Guid.NewGuid().ToString();
            guidKey = Path.ChangeExtension(guidKey, "jpg");
            var filePath = @"C:\Users\igmo\source\repos\ReCapProject\WebAPI\Images\CarImages\" + guidKey;

            IResult result = null;

            if (image.Length > 0)
            {
                await using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await image.CopyToAsync(stream);
                }

                var carImage = _carImageService.GetCarImageById(imageId).Data;
                carImage.ImagePath = filePath;
                carImage.Date=DateTime.Now;

                result = _carImageService.Update(carImage);
            }

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("deletefile")]
        public IActionResult Delete([FromForm] int imageId)
        {
            var image = _carImageService.GetCarImageById(imageId).Data;

            var result = _carImageService.Delete(image);

            if (result.Success)
            {
                System.IO.File.Delete(image.ImagePath);
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getallbycarid")]
        public IActionResult GetCarImages([FromForm] int carId)
        {
            var result = _carImageService.GetCarImageByCarId(carId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
