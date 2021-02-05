using Cursos.Data;
using Cursos.Models;
using CursosAPI.Controllers;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace CursoTeste //Ctrl+R+T - Gerenciador de Testes
{
    public class CursosControllerTest
    {
        private readonly Mock<DbSet<Curso>> _mockSet;
        private readonly Mock<Context> _mockContext;
        private readonly Curso _curso;

        public CursosControllerTest()
        {
            _mockSet = new Mock<DbSet<Curso>>();
            _mockContext = new Mock<Context>();
            _curso = new Curso { Id = 1, Nome = "JavaScript", Plataforma = new Plataforma { Nome = "Digital Innovation One" } };

            _mockContext.Setup(m => m.Cursos).Returns(_mockSet.Object);

            _mockContext.Setup(m => m.Cursos.FindAsync(1)).ReturnsAsync(_curso);

            _mockContext.Setup(m => m.SetModified(_curso));

            _mockContext.Setup(m => m.SaveChangesAsync(It.IsAny<CancellationToken>())).ReturnsAsync(1);
        }

        [Fact]
        public async Task Get_Curso()
        {
            var service = new CursosController(_mockContext.Object);

            await service.GetCurso(1);

            _mockSet.Verify(x => x.FindAsync(1),
                Times.Once());
        }   
        
        [Fact]
        public async Task Put_Curso()
        {
            var service = new CursosController(_mockContext.Object);

            await service.PutCurso(1, _curso);

            _mockContext.Verify(m => m.SaveChangesAsync(It.IsAny<CancellationToken>()),
                Times.Once());
        }

        [Fact]
        public async Task Post_Curso()
        {
            var service = new CursosController(_mockContext.Object);

            await service.PostCurso(_curso);

            _mockSet.Verify(x => x.Add(_curso), Times.Once());
            _mockContext.Verify(x => x.SaveChangesAsync(It.IsAny<CancellationToken>()),
                Times.Once());
        }
        [Fact]
        public async Task Delete_Curso()
        {
            var service = new CursosController(_mockContext.Object);

            await service.DeleteCurso(1);

            _mockSet.Verify(m => m.FindAsync(1), Times.Once());

            _mockSet.Verify(x => x.Remove(_curso), Times.Once);

            _mockContext.Verify(m => m.SaveChangesAsync(It.IsAny<CancellationToken>()),
                Times.Once());
        }
    }
}
