export default () => ({
  app: {
    port: Number(process.env.PORT),
    environment: process.env.NODE_ENV,
  },

  jwt: {
    secret: process.env.JWT_SECRET,
    expiresIn: process.env.JWT_EXPIRES_IN,
  },

  database: {
    url: process.env.DATABASE_URL,
  },
});
