using UnityEngine;
using System;

public class Player : CollectionFactory, ThrowCollection,  VisionMode {

	public int NumberOfLives { get; set; }
	public Collection CurrentCollection { get; set; }
	public Player() {
	}
	public void Throw () {
	}
	public void Vision () {
	}
	public void CreateCollection() {}
}
