﻿

using System;
using Tlabs.Server.Model;

namespace Tlabs.Server.Auth {

  ///<summary>Registry for managing API Keys</summary>
  public interface IApiKeyRegistry {

    ///<summary>Registers the <paramref name="key"/> with a unique <paramref name="tokenName"/> and optional <paramref name="description"/> and <paramref name="validUntil"/></summary>
    ///<returns>The registered key token</returns>
    KeyToken Register(string key, string tokenName, string description= null, DateTime? validUntil= null);

    ///<summary>Deregisters the key with the specified <paramref name="tokenName"/></summary>
    KeyToken Deregister(string tokenName);

    ///<summary>Returns an array of all currently registered key tokens, including keys that are expired but not deleted</summary>
    KeyToken[] RegisteredKeys();

    ///<summary>Returns the total number of registered keys</summary>
    int RegisteredKeyCount();

    ///<summary>Key verification routine</summary>
    ///<returns>The <cref name="KeyToken"/> associated with the <paramref name="key"/> if the key is valid, null otherwise</returns>
    KeyToken VerifiedKey(string key);

    ///<summary>Generates a random, cryptographic API key</summary>
    string GenerateKey();

  }
}