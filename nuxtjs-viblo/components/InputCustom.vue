<template>
  <div class="form__group field">
    <input
      type="text"
      class="form__field"
      placeholder="Câu hỏi chưa được đặt tiêu đề"
      name="name"
      id="name"
      required
      v-model="inputValue"
      ref="input"
      @blur="handleBlur"
      @keyup.enter="handleSubmit"
    />
  </div>
</template>
<script>
export default {
  props: {
    value: {
      type: String,
      default: "Text something here",
    },
  },
  data() {
    return {
      editing: false,
      inputValue: this.value,
    };
  },

  mounted() {
    this.$refs.input.focus();
  },
  methods: {
    handleClick() {
      this.editing = true;
      this.$nextTick(() => this.$refs.input.focus());
    },
    handleSubmit() {
      this.$emit("update:value", this.inputValue);
      this.editing = false;
    },
    handleBlur() {
      this.editing = false;
      if (this.inputValue == null || this.inputValue == "") {
        this.inputValue = "Text something here";
      }
    },
  },
  watch: {
    inputValue(newValue) {
      console.log("🚀 ~ file: InputCustom.vue:20 ~ get ~ value:", newValue);
    },
  },
};
</script>
<style lang="scss" scoped>
$primary: #11998e;
$secondary: #38ef7d;
$white: #fff;
$gray: #9b9b9b;
$black: #000;
.form__group {
  position: relative;
  // width: 50%;
}

.form__field {
  font-family: inherit;
  // width: 100%;
  border: 0;
  outline: 0;
  color: $white;
  font-size: 1rem;
  font-weight: bold;
  min-width: 300px;
  // // padding: 7px 0;
  // border-bottom: 1px solid black;
  background: transparent;
  // transition: border-color 0.2s;

  &::placeholder {
    color: transparent;
  }

  &:placeholder-shown ~ .form__label {
    font-size: 1.3rem;
    cursor: text;
    top: 20px;
  }
}

.form__field {
  &:required,
  &:invalid {
    box-shadow: none;
  }
}
</style>
