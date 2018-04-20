using System.Collections.Generic;
using System;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private string _phoneNumber;
    private string _address;
    private int _id;
    public static int contactCounter;
    private static List<Contact> _instances = new List<Contact> {};

    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetPhoneNumber(string newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }
    public string GetAddresss()
    {
      return _address;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    public int GetId()
    {
      return _id;
    }
    public Contact (string name, string phoneNumber, string address)
    {
      _name = name;
      _phoneNumber = phoneNumber;
      _address = address;
      _id = contactCounter;
      _instances.Add(this);
      contactCounter++;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
