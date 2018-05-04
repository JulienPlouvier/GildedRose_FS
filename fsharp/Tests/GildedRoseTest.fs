module GildedRoseTest

open GildedRose
open System
open System.IO
open System.Text
open System.Collections.Generic
open Xunit

let shouldEqual expected actual = Assert.Equal(expected, actual)

type GildedRoseTest () as this =
    [<Fact>] member this.Foo ()=
        let Items = new List<Item>()  
        Items.Add({Name = "fixme"; SellIn = 0; Quality = 0})
        let app = new GildedRose(Items)
        app.UpdateQuality()
        Items.[0].Name |> shouldEqual "fixme" 

//type ApprovalTest () as this =
//    [<Test>] member this.ThirtyDays ()=
//        let fakeoutput = new StringBuilder()
//        Console.SetOut(new StringWriter(fakeoutput))
//        Console.SetIn(new StringReader("a\n"))

//        main Array.empty<string>
//        let output = fakeoutput.ToString()
//        Approvals.Verify(output)
//        ()