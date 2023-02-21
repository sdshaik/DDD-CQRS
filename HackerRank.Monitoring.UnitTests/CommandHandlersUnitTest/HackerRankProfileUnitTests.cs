using HackerRank.Monitoring.Api.CommandHandlers.HackerRankProfileCommandHandler;
using HackerRank.Monitoring.Api.Commands.HackerRankProfileCommands;
using HackerRank.Monitoring.Domain.IRepositories;
using HackerRank.Monitoring.Domain.Models;
using Moq;

namespace HackerRank.Monitoring.UnitTest.CommandHandlersUnitTest
{
    public class HackerRankProfileUnitTests
    {
        [Fact]
        public async Task Handle_SetsHackerRankProfile_ReturnsUserId()
        {
            // Arrange
            var request = new SetHackerRankProfileCommand
            {
                HR_UserName = "johndoe",
                HR_Email = "johndoe@example.com",
                HR_Badges = 5
            };

            var expectedResult = 123;
            var mockHackerRankProfileRepository = new Mock<IHackerRankProfileRepository>();
            mockHackerRankProfileRepository.Setup(x => x.PostHackerRank_Profile(It.IsAny<HackerRank_Profile>()))
                .Returns(Task.FromResult(expectedResult));

            var handler = new SetHackerRankProfileCommandHandler(mockHackerRankProfileRepository.Object);

            // Act
            var result = await handler.Handle(request, CancellationToken.None);

            // Assert
            Assert.Equal(expectedResult, result);
            mockHackerRankProfileRepository.Verify(x => x.PostHackerRank_Profile(It.IsAny<HackerRank_Profile>()), Times.Once());
        }

        [Fact]
        public async Task HandleShouldDeleteHackerRankProfile()
        {
            // Arrange
            var request = new DeleteHackerRankProfileCommand { User_Id = 1 };

            var hackerRankProfile = new HackerRank_Profile();

            var mockRepository = new Mock<IHackerRankProfileRepository>();
            mockRepository.Setup(x => x.GetHackerRank_ProfilebyId(request.User_Id))
                          .Returns(Task.FromResult(hackerRankProfile));
            mockRepository.Setup(x => x.DeleteHackerRankProfile(hackerRankProfile))
                          .Returns(Task.FromResult(0));

            var handler = new DeleteHackerRankProfileCommandHandler(mockRepository.Object);

            // Act
            var result = await handler.Handle(request, CancellationToken.None);

            // Assert
            mockRepository.Verify(x => x.GetHackerRank_ProfilebyId(request.User_Id), Times.Once);
            mockRepository.Verify(x => x.DeleteHackerRankProfile(hackerRankProfile), Times.Once);
            Assert.Equal(1, result.User_Id);
            Assert.Equal("testuser", result.HR_UserName);
            Assert.Equal("test@example.com", result.HR_Email);
            Assert.Equal(5, result.HR_Badges);
        }

        [Fact]
        public async Task Handle_Should_Delete_HackerRank_Profile()
        {
            // Arrange
            var request = new DeleteHackerRankProfileCommand { User_Id = 1 };

            var hackerRankProfile = new HackerRank_Profile();

            var mockRepository = new Mock<IHackerRankProfileRepository>();
            mockRepository.Setup(x => x.GetHackerRank_ProfilebyId(request.User_Id))
                          .Returns(Task.FromResult(hackerRankProfile));
            mockRepository.Setup(x => x.DeleteHackerRankProfile(hackerRankProfile))
                          .Returns(Task.FromResult(0));

            var handler = new DeleteHackerRankProfileCommandHandler(mockRepository.Object);

            // Act
            var result = await handler.Handle(request, CancellationToken.None);

            // Assert
            mockRepository.Verify(x => x.GetHackerRank_ProfilebyId(request.User_Id), Times.Once);
            mockRepository.Verify(x => x.DeleteHackerRankProfile(hackerRankProfile), Times.Once);
            Assert.Equal(1, result.User_Id);
            Assert.Equal("testuser", result.HR_UserName);
            Assert.Equal("test@example.com", result.HR_Email);
            Assert.Equal(5, result.HR_Badges);
        }
    }
}
