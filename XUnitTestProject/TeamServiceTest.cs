using Interfaces;
using Moq;
using Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject
{
    public class TeamServiceTest
    {
        private Mock<ITeamRepository> repoMock;

        public TeamServiceTest()
        {
            repoMock = new Mock<ITeamRepository>();
        }

        #region CreateTeamService

        [Fact]
        public void CreateTeamService_WithValidRepository()
        {
            // arrange
            var repo = repoMock.Object;

            // act
            var service = new TeamService(repo);

            // assert
            Assert.NotNull(service);
        }

        [Fact]
        public void CreateTeamService_RepositoryIsNull_ExpectArgumentException()
        {
            // arrange
            TeamService service = null;

            // act + assert
            var ex = Assert.Throws<ArgumentException>(() =>
            {
                service = new TeamService(null);
            });

            Assert.Equal("TeamRepository is missing", ex.Message);
            Assert.Null(service);
        }
        #endregion
    }
}

