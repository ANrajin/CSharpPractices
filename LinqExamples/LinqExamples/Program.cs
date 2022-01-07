using System;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region use-of-Where-clause
            //RestrictionOrFiltering rf = new RestrictionOrFiltering();
            //rf.LowNumbers();
            //rf.ProductsOutOfStock();
            //rf.ExpensiveProductsInStock();
            //rf.CustomerOrders();
            //rf.IndexedWhere();
            //rf.TeenAgers();
            //rf.TeenAgersTwo();
            #endregion

            #region use-of-join
            //Joining j = new Joining();
            //j.CrossJoinQuery();
            //j.GroupJoinQuery();
            //j.CrossGroupJoin();
            //j.LeftOuterJoin();
            #endregion

            #region Order
            //Ordering o = new Ordering();
            //o.OrderBySyntex();
            //o.OrderByProperty();
            //o.OrderByProducts();
            //o.OrderByWithCustomComparer();
            //o.OrderByDescendingSyntax();
            //o.OrderProductsDescending();
            //o.DescendingCustomComparer();
            //o.ThenBySyntax();
            //o.ThenByCustom();
            //o.ThenByDifferentOrdering();
            //o.CustomThenByDescending();
            //o.ReverseOrdering();
            #endregion

            #region GroupJoining
            //GroupJoining g = new GroupJoining();
            //g.GroupingSyntax();
            //g.GroupByProperty();
            //g.GroupByCategory();
            //g.NestedGrouBy();
            //g.GrpByCategory();
            #endregion

            #region Projection
            //SelectQuery s = new SelectQuery();
            //s.ExampleOne();
            //s.ExampleTwo();
            //s.DeferredExecution();
            //s.EagerExecution();
            //s.ReUseQueryExecution();
            #endregion

            #region Quantifiers
            //Quantifiers q = new Quantifiers();
            //q.AnyMatchingElement();
            //q.GroupByAnyMatchedElement();
            #endregion

            #region Aggregations
            //Aggregations a = new Aggregations();
            //a.CountSyntex();
            //a.ConditionalCount();
            //a.NestedCount();
            //a.GroupedCount();
            //a.SumSyntex();
            //a.SumProjection();
            //a.SumGrouped();
            //a.MinSyntex();
            //a.MinProjection();
            //a.MinGroup();
            //a.MinEachGroup();
            //a.MaxSyntex();
            //a.MaxProjection();
            //a.MaxGroup();
            //a.MaxInEachGroup();
            //a.AverageSyntex();
            //a.AverageProjection();
            //a.AverageGrouped();
            //a.AggragateSyntex();
            //a.SeededAggragate();
            //a.AggregateWithResultSelector();
            #endregion

            #region Convertions
            //Convertions c = new Convertions();
            //c.ConvertToArray();
            //c.ConvertToList();
            //c.ConvertToDictionary();
            //c.ConvertSelectedItems();
            #endregion

            #region Element-Operation
            //ElementOperations e = new ElementOperations();
            //e.FirstElement();
            //e.FirstMatchingElement();
            //e.MayBeFirstElement();
            //e.MayBeFirstMatchingElement();
            //e.ElementAtPosition();
            #endregion

            #region Generators
            //Generators g = new Generators();
            //g.RangeOfInteger();
            //g.RepeatNumber();
            #endregion

            #region Partitions
            //Partitions p = new Partitions();
            //p.TakeSyntex();
            //p.NestedTake();
            //p.SkipSyntex();
            //p.NestedSkipSyntex();
            #endregion

            #region Projections
            //Projections proj = new Projections();
            //proj.SelectSyntex();
            //proj.SelectProperty();
            //proj.TransformWithSelect();
            //proj.SelectByCaseAnonymous();
            //proj.SelectByCaseTuple();
            //proj.SelectAnonumousConstruction();
            //proj.SelectByCaseTuple();
            //proj.SelectPropertySubset();
            //proj.SelectWithIndex();
            //proj.SelectWithWhere();
            //proj.SelectFromMultipleSequences();
            //proj.SelectFromChildSequence();
            //proj.SelectManyWithWhere();
            //proj.SelectWithMultipleWhereClause();
            //proj.IndexedSelectMany();
            #endregion

            #region QueryExcution
            //QueryExecutions qe = new QueryExecutions();
            //qe.DefferedExecution();
            //qe.EagerExecution();
            //qe.ReuseQueryExecution();
            #endregion

            #region Sequence Operations
            //SequenceOperations sqo = new SequenceOperations();
            //sqo.EqualSequence();
            //sqo.concateSeries();
            //sqo.ConcateProjection();
            //sqo.DotProduct();
            #endregion

            #region Set Operation
            //SetOperations so = new SetOperations();
            //so.DistinctSyntex();
            //so.DistinctPropertyValue();
            //so.ExceptSyntex();
            //so.IntersectSyntex();
            //so.UnionSyntex();
            //so.UnionQueryResult();
            //so.IntersectQueryResult();
            //so.DifferenceOfQueries();
            #endregion

            #region Use of Let
            LetKeyword lk = new LetKeyword();
            //lk.WithoutLet();
            //lk.QueryWithLet();
            #endregion

            #region Use of into
            IntoKeyword ik = new IntoKeyword();
            ik.UseIntoKeyword();
            #endregion
        }
    }
}
