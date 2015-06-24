using System;
using System.Linq.Expressions;

namespace Fold
{
    public static class Inject
    {

        /// <summary>
        /// Marks a location inside an expression where
        /// the specified expression is to be inserted.
        /// </summary>
        /// <typeparam name="TResult">Type of the expression's return value</typeparam>
        /// <param name="expression">The expression to be injected</param>
        public static TResult Expression<TResult>(Expression<Func<TResult>> expression)
        {
            throw new NotSupportedException("Calling this method directly is not supported; it is meant to be used inside an Expression. Did you forget to call Transform() on the expression ?");
        }

        /// <summary>
        /// Marks a location inside an expression where
        /// the specified expression is to be inserted.
        /// </summary>
        /// <typeparam name="TResult">Type of the expression's return value</typeparam>
        /// <typeparam name="T1">The type of parameter #1</typeparam>
        /// <param name="arg1">The value to use for parameter #1</param>
        /// <param name="expression">The expression to be injected</param>
        public static TResult Expression<T1, TResult>(T1 arg1, Expression<Func<T1, TResult>> expression)
        {
            throw new NotSupportedException("Calling this method directly is not supported; it is meant to be used inside an Expression. Did you forget to call Transform() on the expression ?");
        }

        /// <summary>
        /// Marks a location inside an expression where
        /// the specified expression is to be inserted.
        /// </summary>
        /// <typeparam name="TResult">Type of the expression's return value</typeparam>
        /// <typeparam name="T1">The type of parameter #1</typeparam>
        /// <param name="arg1">The value to use for parameter #1</param>
        /// <typeparam name="T2">The type of parameter #2</typeparam>
        /// <param name="arg2">The value to use for parameter #2</param>
        /// <param name="expression">The expression to be injected</param>
        public static TResult Expression<T1, T2, TResult>(T1 arg1, T2 arg2, Expression<Func<T1, T2, TResult>> expression)
        {
            throw new NotSupportedException("Calling this method directly is not supported; it is meant to be used inside an Expression. Did you forget to call Transform() on the expression ?");
        }

        /// <summary>
        /// Marks a location inside an expression where
        /// the specified expression is to be inserted.
        /// </summary>
        /// <typeparam name="TResult">Type of the expression's return value</typeparam>
        /// <typeparam name="T1">The type of parameter #1</typeparam>
        /// <param name="arg1">The value to use for parameter #1</param>
        /// <typeparam name="T2">The type of parameter #2</typeparam>
        /// <param name="arg2">The value to use for parameter #2</param>
        /// <typeparam name="T3">The type of parameter #3</typeparam>
        /// <param name="arg3">The value to use for parameter #3</param>
        /// <param name="expression">The expression to be injected</param>
        public static TResult Expression<T1, T2, T3, TResult>(T1 arg1, T2 arg2, T3 arg3, Expression<Func<T1, T2, T3, TResult>> expression)
        {
            throw new NotSupportedException("Calling this method directly is not supported; it is meant to be used inside an Expression. Did you forget to call Transform() on the expression ?");
        }

        /// <summary>
        /// Marks a location inside an expression where
        /// the specified expression is to be inserted.
        /// </summary>
        /// <typeparam name="TResult">Type of the expression's return value</typeparam>
        /// <typeparam name="T1">The type of parameter #1</typeparam>
        /// <param name="arg1">The value to use for parameter #1</param>
        /// <typeparam name="T2">The type of parameter #2</typeparam>
        /// <param name="arg2">The value to use for parameter #2</param>
        /// <typeparam name="T3">The type of parameter #3</typeparam>
        /// <param name="arg3">The value to use for parameter #3</param>
        /// <typeparam name="T4">The type of parameter #4</typeparam>
        /// <param name="arg4">The value to use for parameter #4</param>
        /// <param name="expression">The expression to be injected</param>
        public static TResult Expression<T1, T2, T3, T4, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, Expression<Func<T1, T2, T3, T4, TResult>> expression)
        {
            throw new NotSupportedException("Calling this method directly is not supported; it is meant to be used inside an Expression. Did you forget to call Transform() on the expression ?");
        }

        /// <summary>
        /// Marks a location inside an expression where
        /// the specified expression is to be inserted.
        /// </summary>
        /// <typeparam name="TResult">Type of the expression's return value</typeparam>
        /// <typeparam name="T1">The type of parameter #1</typeparam>
        /// <param name="arg1">The value to use for parameter #1</param>
        /// <typeparam name="T2">The type of parameter #2</typeparam>
        /// <param name="arg2">The value to use for parameter #2</param>
        /// <typeparam name="T3">The type of parameter #3</typeparam>
        /// <param name="arg3">The value to use for parameter #3</param>
        /// <typeparam name="T4">The type of parameter #4</typeparam>
        /// <param name="arg4">The value to use for parameter #4</param>
        /// <typeparam name="T5">The type of parameter #5</typeparam>
        /// <param name="arg5">The value to use for parameter #5</param>
        /// <param name="expression">The expression to be injected</param>
        public static TResult Expression<T1, T2, T3, T4, T5, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, Expression<Func<T1, T2, T3, T4, T5, TResult>> expression)
        {
            throw new NotSupportedException("Calling this method directly is not supported; it is meant to be used inside an Expression. Did you forget to call Transform() on the expression ?");
        }

        /// <summary>
        /// Marks a location inside an expression where
        /// the specified expression is to be inserted.
        /// </summary>
        /// <typeparam name="TResult">Type of the expression's return value</typeparam>
        /// <typeparam name="T1">The type of parameter #1</typeparam>
        /// <param name="arg1">The value to use for parameter #1</param>
        /// <typeparam name="T2">The type of parameter #2</typeparam>
        /// <param name="arg2">The value to use for parameter #2</param>
        /// <typeparam name="T3">The type of parameter #3</typeparam>
        /// <param name="arg3">The value to use for parameter #3</param>
        /// <typeparam name="T4">The type of parameter #4</typeparam>
        /// <param name="arg4">The value to use for parameter #4</param>
        /// <typeparam name="T5">The type of parameter #5</typeparam>
        /// <param name="arg5">The value to use for parameter #5</param>
        /// <typeparam name="T6">The type of parameter #6</typeparam>
        /// <param name="arg6">The value to use for parameter #6</param>
        /// <param name="expression">The expression to be injected</param>
        public static TResult Expression<T1, T2, T3, T4, T5, T6, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, Expression<Func<T1, T2, T3, T4, T5, T6, TResult>> expression)
        {
            throw new NotSupportedException("Calling this method directly is not supported; it is meant to be used inside an Expression. Did you forget to call Transform() on the expression ?");
        }

        /// <summary>
        /// Marks a location inside an expression where
        /// the specified expression is to be inserted.
        /// </summary>
        /// <typeparam name="TResult">Type of the expression's return value</typeparam>
        /// <typeparam name="T1">The type of parameter #1</typeparam>
        /// <param name="arg1">The value to use for parameter #1</param>
        /// <typeparam name="T2">The type of parameter #2</typeparam>
        /// <param name="arg2">The value to use for parameter #2</param>
        /// <typeparam name="T3">The type of parameter #3</typeparam>
        /// <param name="arg3">The value to use for parameter #3</param>
        /// <typeparam name="T4">The type of parameter #4</typeparam>
        /// <param name="arg4">The value to use for parameter #4</param>
        /// <typeparam name="T5">The type of parameter #5</typeparam>
        /// <param name="arg5">The value to use for parameter #5</param>
        /// <typeparam name="T6">The type of parameter #6</typeparam>
        /// <param name="arg6">The value to use for parameter #6</param>
        /// <typeparam name="T7">The type of parameter #7</typeparam>
        /// <param name="arg7">The value to use for parameter #7</param>
        /// <param name="expression">The expression to be injected</param>
        public static TResult Expression<T1, T2, T3, T4, T5, T6, T7, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, Expression<Func<T1, T2, T3, T4, T5, T6, T7, TResult>> expression)
        {
            throw new NotSupportedException("Calling this method directly is not supported; it is meant to be used inside an Expression. Did you forget to call Transform() on the expression ?");
        }

        /// <summary>
        /// Marks a location inside an expression where
        /// the specified expression is to be inserted.
        /// </summary>
        /// <typeparam name="TResult">Type of the expression's return value</typeparam>
        /// <typeparam name="T1">The type of parameter #1</typeparam>
        /// <param name="arg1">The value to use for parameter #1</param>
        /// <typeparam name="T2">The type of parameter #2</typeparam>
        /// <param name="arg2">The value to use for parameter #2</param>
        /// <typeparam name="T3">The type of parameter #3</typeparam>
        /// <param name="arg3">The value to use for parameter #3</param>
        /// <typeparam name="T4">The type of parameter #4</typeparam>
        /// <param name="arg4">The value to use for parameter #4</param>
        /// <typeparam name="T5">The type of parameter #5</typeparam>
        /// <param name="arg5">The value to use for parameter #5</param>
        /// <typeparam name="T6">The type of parameter #6</typeparam>
        /// <param name="arg6">The value to use for parameter #6</param>
        /// <typeparam name="T7">The type of parameter #7</typeparam>
        /// <param name="arg7">The value to use for parameter #7</param>
        /// <typeparam name="T8">The type of parameter #8</typeparam>
        /// <param name="arg8">The value to use for parameter #8</param>
        /// <param name="expression">The expression to be injected</param>
        public static TResult Expression<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> expression)
        {
            throw new NotSupportedException("Calling this method directly is not supported; it is meant to be used inside an Expression. Did you forget to call Transform() on the expression ?");
        }

        /// <summary>
        /// Marks a location inside an expression where
        /// the specified expression is to be inserted.
        /// </summary>
        /// <typeparam name="TResult">Type of the expression's return value</typeparam>
        /// <typeparam name="T1">The type of parameter #1</typeparam>
        /// <param name="arg1">The value to use for parameter #1</param>
        /// <typeparam name="T2">The type of parameter #2</typeparam>
        /// <param name="arg2">The value to use for parameter #2</param>
        /// <typeparam name="T3">The type of parameter #3</typeparam>
        /// <param name="arg3">The value to use for parameter #3</param>
        /// <typeparam name="T4">The type of parameter #4</typeparam>
        /// <param name="arg4">The value to use for parameter #4</param>
        /// <typeparam name="T5">The type of parameter #5</typeparam>
        /// <param name="arg5">The value to use for parameter #5</param>
        /// <typeparam name="T6">The type of parameter #6</typeparam>
        /// <param name="arg6">The value to use for parameter #6</param>
        /// <typeparam name="T7">The type of parameter #7</typeparam>
        /// <param name="arg7">The value to use for parameter #7</param>
        /// <typeparam name="T8">The type of parameter #8</typeparam>
        /// <param name="arg8">The value to use for parameter #8</param>
        /// <typeparam name="T9">The type of parameter #9</typeparam>
        /// <param name="arg9">The value to use for parameter #9</param>
        /// <param name="expression">The expression to be injected</param>
        public static TResult Expression<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> expression)
        {
            throw new NotSupportedException("Calling this method directly is not supported; it is meant to be used inside an Expression. Did you forget to call Transform() on the expression ?");
        }

        /// <summary>
        /// Marks a location inside an expression where
        /// the specified expression is to be inserted.
        /// </summary>
        /// <typeparam name="TResult">Type of the expression's return value</typeparam>
        /// <typeparam name="T1">The type of parameter #1</typeparam>
        /// <param name="arg1">The value to use for parameter #1</param>
        /// <typeparam name="T2">The type of parameter #2</typeparam>
        /// <param name="arg2">The value to use for parameter #2</param>
        /// <typeparam name="T3">The type of parameter #3</typeparam>
        /// <param name="arg3">The value to use for parameter #3</param>
        /// <typeparam name="T4">The type of parameter #4</typeparam>
        /// <param name="arg4">The value to use for parameter #4</param>
        /// <typeparam name="T5">The type of parameter #5</typeparam>
        /// <param name="arg5">The value to use for parameter #5</param>
        /// <typeparam name="T6">The type of parameter #6</typeparam>
        /// <param name="arg6">The value to use for parameter #6</param>
        /// <typeparam name="T7">The type of parameter #7</typeparam>
        /// <param name="arg7">The value to use for parameter #7</param>
        /// <typeparam name="T8">The type of parameter #8</typeparam>
        /// <param name="arg8">The value to use for parameter #8</param>
        /// <typeparam name="T9">The type of parameter #9</typeparam>
        /// <param name="arg9">The value to use for parameter #9</param>
        /// <typeparam name="T10">The type of parameter #10</typeparam>
        /// <param name="arg10">The value to use for parameter #10</param>
        /// <param name="expression">The expression to be injected</param>
        public static TResult Expression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> expression)
        {
            throw new NotSupportedException("Calling this method directly is not supported; it is meant to be used inside an Expression. Did you forget to call Transform() on the expression ?");
        }

        /// <summary>
        /// Marks a location inside an expression where
        /// the specified expression is to be inserted.
        /// </summary>
        /// <typeparam name="TResult">Type of the expression's return value</typeparam>
        /// <typeparam name="T1">The type of parameter #1</typeparam>
        /// <param name="arg1">The value to use for parameter #1</param>
        /// <typeparam name="T2">The type of parameter #2</typeparam>
        /// <param name="arg2">The value to use for parameter #2</param>
        /// <typeparam name="T3">The type of parameter #3</typeparam>
        /// <param name="arg3">The value to use for parameter #3</param>
        /// <typeparam name="T4">The type of parameter #4</typeparam>
        /// <param name="arg4">The value to use for parameter #4</param>
        /// <typeparam name="T5">The type of parameter #5</typeparam>
        /// <param name="arg5">The value to use for parameter #5</param>
        /// <typeparam name="T6">The type of parameter #6</typeparam>
        /// <param name="arg6">The value to use for parameter #6</param>
        /// <typeparam name="T7">The type of parameter #7</typeparam>
        /// <param name="arg7">The value to use for parameter #7</param>
        /// <typeparam name="T8">The type of parameter #8</typeparam>
        /// <param name="arg8">The value to use for parameter #8</param>
        /// <typeparam name="T9">The type of parameter #9</typeparam>
        /// <param name="arg9">The value to use for parameter #9</param>
        /// <typeparam name="T10">The type of parameter #10</typeparam>
        /// <param name="arg10">The value to use for parameter #10</param>
        /// <typeparam name="T11">The type of parameter #11</typeparam>
        /// <param name="arg11">The value to use for parameter #11</param>
        /// <param name="expression">The expression to be injected</param>
        public static TResult Expression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> expression)
        {
            throw new NotSupportedException("Calling this method directly is not supported; it is meant to be used inside an Expression. Did you forget to call Transform() on the expression ?");
        }

        /// <summary>
        /// Marks a location inside an expression where
        /// the specified expression is to be inserted.
        /// </summary>
        /// <typeparam name="TResult">Type of the expression's return value</typeparam>
        /// <typeparam name="T1">The type of parameter #1</typeparam>
        /// <param name="arg1">The value to use for parameter #1</param>
        /// <typeparam name="T2">The type of parameter #2</typeparam>
        /// <param name="arg2">The value to use for parameter #2</param>
        /// <typeparam name="T3">The type of parameter #3</typeparam>
        /// <param name="arg3">The value to use for parameter #3</param>
        /// <typeparam name="T4">The type of parameter #4</typeparam>
        /// <param name="arg4">The value to use for parameter #4</param>
        /// <typeparam name="T5">The type of parameter #5</typeparam>
        /// <param name="arg5">The value to use for parameter #5</param>
        /// <typeparam name="T6">The type of parameter #6</typeparam>
        /// <param name="arg6">The value to use for parameter #6</param>
        /// <typeparam name="T7">The type of parameter #7</typeparam>
        /// <param name="arg7">The value to use for parameter #7</param>
        /// <typeparam name="T8">The type of parameter #8</typeparam>
        /// <param name="arg8">The value to use for parameter #8</param>
        /// <typeparam name="T9">The type of parameter #9</typeparam>
        /// <param name="arg9">The value to use for parameter #9</param>
        /// <typeparam name="T10">The type of parameter #10</typeparam>
        /// <param name="arg10">The value to use for parameter #10</param>
        /// <typeparam name="T11">The type of parameter #11</typeparam>
        /// <param name="arg11">The value to use for parameter #11</param>
        /// <typeparam name="T12">The type of parameter #12</typeparam>
        /// <param name="arg12">The value to use for parameter #12</param>
        /// <param name="expression">The expression to be injected</param>
        public static TResult Expression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> expression)
        {
            throw new NotSupportedException("Calling this method directly is not supported; it is meant to be used inside an Expression. Did you forget to call Transform() on the expression ?");
        }

        /// <summary>
        /// Marks a location inside an expression where
        /// the specified expression is to be inserted.
        /// </summary>
        /// <typeparam name="TResult">Type of the expression's return value</typeparam>
        /// <typeparam name="T1">The type of parameter #1</typeparam>
        /// <param name="arg1">The value to use for parameter #1</param>
        /// <typeparam name="T2">The type of parameter #2</typeparam>
        /// <param name="arg2">The value to use for parameter #2</param>
        /// <typeparam name="T3">The type of parameter #3</typeparam>
        /// <param name="arg3">The value to use for parameter #3</param>
        /// <typeparam name="T4">The type of parameter #4</typeparam>
        /// <param name="arg4">The value to use for parameter #4</param>
        /// <typeparam name="T5">The type of parameter #5</typeparam>
        /// <param name="arg5">The value to use for parameter #5</param>
        /// <typeparam name="T6">The type of parameter #6</typeparam>
        /// <param name="arg6">The value to use for parameter #6</param>
        /// <typeparam name="T7">The type of parameter #7</typeparam>
        /// <param name="arg7">The value to use for parameter #7</param>
        /// <typeparam name="T8">The type of parameter #8</typeparam>
        /// <param name="arg8">The value to use for parameter #8</param>
        /// <typeparam name="T9">The type of parameter #9</typeparam>
        /// <param name="arg9">The value to use for parameter #9</param>
        /// <typeparam name="T10">The type of parameter #10</typeparam>
        /// <param name="arg10">The value to use for parameter #10</param>
        /// <typeparam name="T11">The type of parameter #11</typeparam>
        /// <param name="arg11">The value to use for parameter #11</param>
        /// <typeparam name="T12">The type of parameter #12</typeparam>
        /// <param name="arg12">The value to use for parameter #12</param>
        /// <typeparam name="T13">The type of parameter #13</typeparam>
        /// <param name="arg13">The value to use for parameter #13</param>
        /// <param name="expression">The expression to be injected</param>
        public static TResult Expression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> expression)
        {
            throw new NotSupportedException("Calling this method directly is not supported; it is meant to be used inside an Expression. Did you forget to call Transform() on the expression ?");
        }

        /// <summary>
        /// Marks a location inside an expression where
        /// the specified expression is to be inserted.
        /// </summary>
        /// <typeparam name="TResult">Type of the expression's return value</typeparam>
        /// <typeparam name="T1">The type of parameter #1</typeparam>
        /// <param name="arg1">The value to use for parameter #1</param>
        /// <typeparam name="T2">The type of parameter #2</typeparam>
        /// <param name="arg2">The value to use for parameter #2</param>
        /// <typeparam name="T3">The type of parameter #3</typeparam>
        /// <param name="arg3">The value to use for parameter #3</param>
        /// <typeparam name="T4">The type of parameter #4</typeparam>
        /// <param name="arg4">The value to use for parameter #4</param>
        /// <typeparam name="T5">The type of parameter #5</typeparam>
        /// <param name="arg5">The value to use for parameter #5</param>
        /// <typeparam name="T6">The type of parameter #6</typeparam>
        /// <param name="arg6">The value to use for parameter #6</param>
        /// <typeparam name="T7">The type of parameter #7</typeparam>
        /// <param name="arg7">The value to use for parameter #7</param>
        /// <typeparam name="T8">The type of parameter #8</typeparam>
        /// <param name="arg8">The value to use for parameter #8</param>
        /// <typeparam name="T9">The type of parameter #9</typeparam>
        /// <param name="arg9">The value to use for parameter #9</param>
        /// <typeparam name="T10">The type of parameter #10</typeparam>
        /// <param name="arg10">The value to use for parameter #10</param>
        /// <typeparam name="T11">The type of parameter #11</typeparam>
        /// <param name="arg11">The value to use for parameter #11</param>
        /// <typeparam name="T12">The type of parameter #12</typeparam>
        /// <param name="arg12">The value to use for parameter #12</param>
        /// <typeparam name="T13">The type of parameter #13</typeparam>
        /// <param name="arg13">The value to use for parameter #13</param>
        /// <typeparam name="T14">The type of parameter #14</typeparam>
        /// <param name="arg14">The value to use for parameter #14</param>
        /// <param name="expression">The expression to be injected</param>
        public static TResult Expression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> expression)
        {
            throw new NotSupportedException("Calling this method directly is not supported; it is meant to be used inside an Expression. Did you forget to call Transform() on the expression ?");
        }

        /// <summary>
        /// Marks a location inside an expression where
        /// the specified expression is to be inserted.
        /// </summary>
        /// <typeparam name="TResult">Type of the expression's return value</typeparam>
        /// <typeparam name="T1">The type of parameter #1</typeparam>
        /// <param name="arg1">The value to use for parameter #1</param>
        /// <typeparam name="T2">The type of parameter #2</typeparam>
        /// <param name="arg2">The value to use for parameter #2</param>
        /// <typeparam name="T3">The type of parameter #3</typeparam>
        /// <param name="arg3">The value to use for parameter #3</param>
        /// <typeparam name="T4">The type of parameter #4</typeparam>
        /// <param name="arg4">The value to use for parameter #4</param>
        /// <typeparam name="T5">The type of parameter #5</typeparam>
        /// <param name="arg5">The value to use for parameter #5</param>
        /// <typeparam name="T6">The type of parameter #6</typeparam>
        /// <param name="arg6">The value to use for parameter #6</param>
        /// <typeparam name="T7">The type of parameter #7</typeparam>
        /// <param name="arg7">The value to use for parameter #7</param>
        /// <typeparam name="T8">The type of parameter #8</typeparam>
        /// <param name="arg8">The value to use for parameter #8</param>
        /// <typeparam name="T9">The type of parameter #9</typeparam>
        /// <param name="arg9">The value to use for parameter #9</param>
        /// <typeparam name="T10">The type of parameter #10</typeparam>
        /// <param name="arg10">The value to use for parameter #10</param>
        /// <typeparam name="T11">The type of parameter #11</typeparam>
        /// <param name="arg11">The value to use for parameter #11</param>
        /// <typeparam name="T12">The type of parameter #12</typeparam>
        /// <param name="arg12">The value to use for parameter #12</param>
        /// <typeparam name="T13">The type of parameter #13</typeparam>
        /// <param name="arg13">The value to use for parameter #13</param>
        /// <typeparam name="T14">The type of parameter #14</typeparam>
        /// <param name="arg14">The value to use for parameter #14</param>
        /// <typeparam name="T15">The type of parameter #15</typeparam>
        /// <param name="arg15">The value to use for parameter #15</param>
        /// <param name="expression">The expression to be injected</param>
        public static TResult Expression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> expression)
        {
            throw new NotSupportedException("Calling this method directly is not supported; it is meant to be used inside an Expression. Did you forget to call Transform() on the expression ?");
        }

        /// <summary>
        /// Marks a location inside an expression where
        /// the specified expression is to be inserted.
        /// </summary>
        /// <typeparam name="TResult">Type of the expression's return value</typeparam>
        /// <typeparam name="T1">The type of parameter #1</typeparam>
        /// <param name="arg1">The value to use for parameter #1</param>
        /// <typeparam name="T2">The type of parameter #2</typeparam>
        /// <param name="arg2">The value to use for parameter #2</param>
        /// <typeparam name="T3">The type of parameter #3</typeparam>
        /// <param name="arg3">The value to use for parameter #3</param>
        /// <typeparam name="T4">The type of parameter #4</typeparam>
        /// <param name="arg4">The value to use for parameter #4</param>
        /// <typeparam name="T5">The type of parameter #5</typeparam>
        /// <param name="arg5">The value to use for parameter #5</param>
        /// <typeparam name="T6">The type of parameter #6</typeparam>
        /// <param name="arg6">The value to use for parameter #6</param>
        /// <typeparam name="T7">The type of parameter #7</typeparam>
        /// <param name="arg7">The value to use for parameter #7</param>
        /// <typeparam name="T8">The type of parameter #8</typeparam>
        /// <param name="arg8">The value to use for parameter #8</param>
        /// <typeparam name="T9">The type of parameter #9</typeparam>
        /// <param name="arg9">The value to use for parameter #9</param>
        /// <typeparam name="T10">The type of parameter #10</typeparam>
        /// <param name="arg10">The value to use for parameter #10</param>
        /// <typeparam name="T11">The type of parameter #11</typeparam>
        /// <param name="arg11">The value to use for parameter #11</param>
        /// <typeparam name="T12">The type of parameter #12</typeparam>
        /// <param name="arg12">The value to use for parameter #12</param>
        /// <typeparam name="T13">The type of parameter #13</typeparam>
        /// <param name="arg13">The value to use for parameter #13</param>
        /// <typeparam name="T14">The type of parameter #14</typeparam>
        /// <param name="arg14">The value to use for parameter #14</param>
        /// <typeparam name="T15">The type of parameter #15</typeparam>
        /// <param name="arg15">The value to use for parameter #15</param>
        /// <typeparam name="T16">The type of parameter #16</typeparam>
        /// <param name="arg16">The value to use for parameter #16</param>
        /// <param name="expression">The expression to be injected</param>
        public static TResult Expression<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> expression)
        {
            throw new NotSupportedException("Calling this method directly is not supported; it is meant to be used inside an Expression. Did you forget to call Transform() on the expression ?");
        }

    }
}
