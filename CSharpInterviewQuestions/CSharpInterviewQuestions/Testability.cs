using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpInterviewQuestions
{
    public class UntestableMedicalScoreCalculator
    {
        public double CalculateAverageMedicalScoreOfPeople()
        {
            var repository = new Repository();
            var allPeople = repository.GetAllPeopleFromDatabase();
            var scores = allPeople.Select(p => StaticMedicalScoreCalculator.GetScore(p));

            return scores.Average();
        }
    }

    public class TestableMedicalScoreCalculator
    {
        private readonly IRepository _repository;
        private readonly IMedicalScoreCalculator _medicalDataAnalyser;

        public TestableMedicalScoreCalculator(IRepository repository, IMedicalScoreCalculator medicalDataAnalyser)
        {
            _repository = repository;
            _medicalDataAnalyser = medicalDataAnalyser;
        }

        public double CalculateAverageMedicalScoreOfPeople()
        {
            var allPeople = _repository.GetAllPeopleFromDatabase();
            var scores = allPeople.Select(p => _medicalDataAnalyser.GetScore(p));

            return scores.Average();
        }
    }

    public static class StaticMedicalScoreCalculator
    {
        private static Random _random = new Random();
        public static int GetScore(Person p)
        {
            //imagine it performs some complex calculations basing on personal data
            return _random.Next(1, 101);
        }
    }

    public interface IMedicalScoreCalculator
    {
        int GetScore(Person p);
    }
    public class MedicalScoreCalculator : IMedicalScoreCalculator
    {
        private Random _random = new Random();
        public int GetScore(Person p)
        {
            //imagine it performs some complex calculations basing on personal data
            return _random.Next(1, 101);
        }
    }
    
    public interface IRepository
    {
        List<Person> GetAllPeopleFromDatabase();
    }

    public class Repository : IRepository
    {
        public List<Person> GetAllPeopleFromDatabase()
        {
            //imagine we connect to a database here and retun real data
            return new List<Person>
            {
            };
        }
    }

    public class Person
    {
        private string _name;

        public Person(string name)
        {
            _name = name;
        }
    }
}
